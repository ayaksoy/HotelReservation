import React from "react";

export default function ContactComp() {
	return (
		<div id="contact">
			<div className="container">
				<div className="section-header">
					<h2>Contact</h2>
					<p>
						Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in
						mi libero. Quisque convallis, enim at venenatis tincidunt.
					</p>
				</div>
				<div className="row">
					<div className="col-md-12">
						<div className="row contact-info">
							<div className="col-md-4">
								<div className="info-item">
									<p>
										<i className="fa fa-map-marker"></i>22 Wolf Road, California
									</p>
								</div>
							</div>
							<div className="col-md-4">
								<div className="info-item">
									<p>
										<i className="fa fa-envelope"></i>{" "}
										<a href="mailto:info@example.com">info@example.com</a>
									</p>
								</div>
							</div>
							<div className="col-md-4">
								<div className="info-item">
									<p>
										<i className="fa fa-phone"></i>
										<a href="tel:+1 234 567 8900">+1 234 567 8900</a>
									</p>
								</div>
							</div>
						</div>
					</div>
					<div className="col-md-12">
						<div className="contact-form">
							<div id="success"></div>
							<form name="sentMessage" id="contactForm" novalidate="novalidate">
								<div className="form-row">
									<div className="control-group col-sm-6">
										<label>Your Name</label>
										<input
											type="text"
											className="form-control"
											id="name"
											placeholder="E.g. John Sina"
											required="required"
											data-validation-required-message="Please enter your name"
										/>
										<p className="help-block text-danger"></p>
									</div>
									<div className="control-group col-sm-6">
										<label>Email</label>
										<input
											type="email"
											className="form-control"
											id="email"
											placeholder="E.g. email@example.com"
											required="required"
											data-validation-required-message="Please enter your email"
										/>
										<p className="help-block text-danger"></p>
									</div>
								</div>
								<div className="control-group">
									<label>Subject</label>
									<input
										type="text"
										className="form-control"
										id="subject"
										placeholder="E.g. Room Booking"
										required="required"
										data-validation-required-message="Please enter a subject"
									/>
									<p className="help-block text-danger"></p>
								</div>
								<div className="control-group">
									<label>Message</label>
									<textarea
										className="form-control"
										id="message"
										rows="5"
										placeholder="E.g. I need a premium room"
										required="required"
										data-validation-required-message="Please enter your message"
									></textarea>
									<p className="help-block text-danger"></p>
								</div>
								<div className="button">
									<button type="submit" id="sendMessageButton">
										Send Message
									</button>
								</div>
							</form>
						</div>
					</div>
				</div>
			</div>
		</div>
	);
}
