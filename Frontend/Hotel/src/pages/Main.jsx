import React from "react";
import Header from "../components/Header";
import HeaderSlider from "../components/HeaderSlider";
import SearchSection from "../components/SearchSection";
import WelcomeSection from "../components/WelcomeSection";
import Amenities from "../components/Amenities";
import OurRooms from "../components/OurRooms";
import Modal from "../components/Modal";
import Booking from "../components/Booking";

export default function Main() {
	return (
		<>
			<HeaderSlider />
			<SearchSection />
			<WelcomeSection />
			<Amenities />
			<OurRooms />
			<Modal />
			<Booking />
			<SearchSection />
		</>
	);
}
