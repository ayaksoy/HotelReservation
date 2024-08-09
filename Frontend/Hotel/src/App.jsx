import { useState } from "react";
import reactLogo from "./assets/react.svg";
import viteLogo from "/vite.svg";
import "./App.css";
import Main from "./pages/Main";
import Header from "./components/Header";
import Footer from "./components/Footer";
import Contact from "./pages/Contact";
import Rooms from "./pages/Rooms";

function App() {
	return (
		<>
			<Header />
			<Rooms />
			<Footer />
		</>
	);
}

export default App;
