import { connect } from "react-redux";
import React, { useEffect, useState } from "react";
import Clock from "react-clock";

import "./App.css";

function App() {
  const [value, setValue] = useState(new Date());

  useEffect(() => {
    const interval = setInterval(() => setValue(new Date()), 1000);
    return () => {
      clearInterval(interval);
    };
  }, []);
  return (
    <div className="App">
      <p>Current time:</p>
      <Clock value={value} />
    </div>
  );
}

// function mapStateToProps(state) {
//   return {
//     currentUser: state.currentUser,
//   };
// }

// function mapDispatchToProps(dispatch) {
//   return {
//     setUser: userObj => {
//       dispatch({ type: "SET_USER", payload: userObj });
//     },
//   };
// }

export default connect()(App);
