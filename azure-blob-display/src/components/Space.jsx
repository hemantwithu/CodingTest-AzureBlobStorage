import { useState } from "react";
import RentRoll from "./RentRoll";

export default function Space({ space }) {
  const [expanded, setExpanded] = useState(false);

  return (
    <div className="space">
      <h3 onClick={() => setExpanded(!expanded)}>
        {space.SpaceName} {expanded ? "▲" : "▼"}
      </h3>
      {expanded && (
        

        <div className="rent-details">
          { space.RentRoll.map((rentRoll,index) => ( 
           <RentRoll key={index} rentRoll={rentRoll} />
          ))}
        </div>
        
      )}
    </div>
  );
}
