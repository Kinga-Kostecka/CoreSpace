import React, { useState, useEffect } from 'react';

interface Reservation {
  id?: number;
  roomName: string;
  reservedBy: string;
  startTime: string;
  endTime: string;
}

const Dashboard: React.FC = () => {
  const [reservations, setReservations] = useState<Reservation[]>([]);
  const [newRoom, setNewRoom] = useState('');
  const [user, setUser] = useState('');
  const [start, setStart] = useState(''); 
  const [end, setEnd] = useState('');     
  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState(false);

const API_URL = `${import.meta.env.VITE_API_URL}/api/Reservations`;

  const fetchReservations = async () => {
    setLoading(true);
    try {
      const response = await fetch(API_URL);
      if (!response.ok) throw new Error();
      const data = await response.json();
      setReservations(data);
    } catch (err) {
      setError("Błąd połączenia z API.");
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => { fetchReservations(); }, []);

  const handleAdd = async () => {
    if (!newRoom || !user || !start || !end) {
      setError("Wszystkie pola (sala, imię, czas od i do) są wymagane!");
      return;
    }

    const payload = {
      roomName: newRoom,
      reservedBy: user,
      startTime: new Date(start).toISOString(),
      endTime: new Date(end).toISOString()
    };

    try {
      const response = await fetch(API_URL, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(payload)
      });

      if (response.ok) {
        setNewRoom(''); setUser(''); setStart(''); setEnd('');
        setError(null);
        fetchReservations();
      } else {
        setError("Błąd serwera przy dodawaniu.");
      }
    } catch (err) {
      setError("Błąd krytyczny połączenia.");
    }
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial', color: 'white', backgroundColor: '#1a1a1a', minHeight: '100vh' }}>
      <h1>Cloud App Dashboard ☁️</h1>

      {loading && <p style={{ color: '#3498db' }}>Ładowanie danych...</p>}
      {error && <div style={{ background: '#e74c3c', padding: '10px', marginBottom: '10px' }}>{error}</div>}

      <div style={{ border: '1px solid #444', padding: '20px', marginBottom: '20px', borderRadius: '8px' }}>
        <h3>Nowa Rezerwacja</h3>
        <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '10px' }}>
          <input placeholder="Nazwa sali" value={newRoom} onChange={(e) => setNewRoom(e.target.value)} />
          <input placeholder="Twoje imię" value={user} onChange={(e) => setUser(e.target.value)} />
          <div>
            <label>Od: </label>
            <input type="datetime-local" value={start} onChange={(e) => setStart(e.target.value)} />
          </div>
          <div>
            <label>Do: </label>
            <input type="datetime-local" value={end} onChange={(e) => setEnd(e.target.value)} />
          </div>
        </div>
        <button onClick={handleAdd} style={{ marginTop: '15px', padding: '10px 20px', cursor: 'pointer' }}>Zarezerwuj Salę</button>
      </div>

      <table border={1} style={{ width: '100%', borderCollapse: 'collapse', textAlign: 'left' }}>
        <thead>
          <tr style={{ background: '#333' }}>
            <th>Sala</th>
            <th>Kto</th>
            <th>Od</th>
            <th>Do</th>
          </tr>
        </thead>
        <tbody>
          {reservations.map((res) => (
            <tr key={res.id}>
              <td>{res.roomName}</td>
              <td>{res.reservedBy}</td>
              <td>{new Date(res.startTime).toLocaleString()}</td>
              <td>{new Date(res.endTime).toLocaleString()}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};

export default Dashboard;
