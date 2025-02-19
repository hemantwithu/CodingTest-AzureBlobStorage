import { useState } from "react";

export default function RentRoll({ rentRoll }) {
    const [expanded, setExpanded] = useState(false);

    return (
        <div className="rent-roll">
            <div className="rent-details"> 
                <ul>
                {Object.entries(rentRoll).map(([Month, Rent]) => (
                <p>{Month}:{Rent}</p>
                ))} 
                </ul>
            </div>
        </div>
    );
}
