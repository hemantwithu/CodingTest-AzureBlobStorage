import { useEffect, useState } from "react";
import axios from "axios";
import Property from "./Property";

const API_URL = "http://localhost:5007/api/properties"; // Update with actual API

export default function PropertyList() {
  const [properties, setProperties] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");

  useEffect(() => {
    axios.get(API_URL)
      .then((response) => {
        setProperties(response.data);
        setLoading(false);
      })
      .catch((error) => {
        console.error("Error fetching data:", error);
        setError("Failed to load data.");
        setLoading(false);
      });
  }, []);

  if (loading) return <p>Loading properties...</p>;
  if (error) return <p>{error}</p>;

  return (
    <div className="container">
      <h1>Property List</h1>
      {properties.map((property) => (
        <Property key={property.PropertyId} property={property} />
      ))}
    </div>
  );
}
