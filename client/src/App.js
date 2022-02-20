import { useEffect, useState } from "react";

function App() {
  const [state, setState] = useState("");

  useEffect(() => {
    fetch("test")
      .then((data) => data.text())
      .then((text) => {
        console.log(text);
        setState(text);
      });
  }, []);
  return <div className="App">{state}</div>;
}

export default App;
