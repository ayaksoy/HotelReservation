import React from "react";

export default function Header() {
	return (
		<>
			<header id="header">
				<a href="index.html" className="logo">
					<img src="img/logo.jpg" alt="logo" />
				</a>
				<div className="phone">
					<i className="fa fa-phone"></i>+1 234 567 8900
				</div>
				<div className="mobile-menu-btn">
					<i className="fa fa-bars"></i>
				</div>
				<nav className="main-menu top-menu">
					<ul>
						<li className="active">
							<a href="index.html">Home</a>
						</li>
						<li>
							<a href="about.html">About Us</a>
						</li>
						<li>
							<a href="room.html">Rooms</a>
						</li>
						<li>
							<a href="amenities.html">Amenities</a>
						</li>
						<li>
							<a href="booking.html">Booking</a>
						</li>
						<li>
							<a href="login.html">Login</a>
						</li>
						<li>
							<a href="contact.html">Contact Us</a>
						</li>
					</ul>
				</nav>
			</header>
		</>
	);
}
