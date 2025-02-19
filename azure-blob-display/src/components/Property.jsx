import { useState } from "react";
import Space from "./Space";

export default function Property({ property }) {
  const [expanded, setExpanded] = useState(false);

  return (
    <div className="property">
      <h2 onClick={() => setExpanded(!expanded)}>
        {property.PropertyName} {expanded ? "▲" : "▼"}
      </h2>
      {expanded && (
        <div className="property-details">
          <p><strong>Features:</strong> {property.Features.join(", ")}</p>
          <p><strong>Highlights:</strong> {property.Highlights.join(", ")}</p>
          <p><strong>Transportation:</strong> {property.Transportation.map((transport,index)=>(
            <li key={index}>
            {transport.Type} - {transport.Line || transport.Station} ({transport.Distance})
          </li>))}</p>
          <div className="spaces">
            {property.Spaces.map((space) => (
              <Space key={space.SpaceId} space={space} />
            ))}
          </div>
        </div>
      )}
    </div>
  );
}
