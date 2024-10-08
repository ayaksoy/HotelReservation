import React from "react";

export default function Booking() {
	return (
		<div id="booking">
			<div className="container">
				<div className="section-header">
					<h2>Room Booking</h2>
					<p>
						Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in
						mi libero. Quisque convallis, enim at venenatis tincidunt.
					</p>
				</div>
				<div className="row">
					<div className="col-12">
						<div className="booking-form">
							<div id="success"></div>
							<form name="sentMessage" id="bookingForm" novalidate="novalidate">
								<div className="form-row">
									<div className="control-group col-sm-6">
										<label>First Name</label>
										<input
											type="text"
											className="form-control"
											id="fname"
											placeholder="E.g. John"
											required="required"
											data-validation-required-message="Please enter first name"
										/>
										<p className="help-block text-danger"></p>
									</div>
									<div className="control-group col-sm-6">
										<label>Last Name</label>
										<input
											type="text"
											className="form-control"
											id="lname"
											placeholder="E.g. Sina"
											required="required"
											data-validation-required-message="Please enter last name"
										/>
										<p className="help-block text-danger"></p>
									</div>
								</div>
								<div className="form-row">
									<div className="control-group col-sm-6">
										<label>Mobile</label>
										<input
											type="text"
											className="form-control"
											id="mobile"
											placeholder="E.g. +1 234 567 8900"
											required="required"
											data-validation-required-message="Please enter your mobile number"
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
								<div className="form-row">
									<div className="control-group col-sm-6">
										<label>Check-In</label>
										<input
											type="text"
											className="form-control datetimepicker-input"
											id="date-1"
											data-toggle="datetimepicker"
											data-target="#date-1"
											placeholder="E.g. MM/DD/YYYY"
											required="required"
											data-validation-required-message="Please enter date"
										/>
										<p className="help-block text-danger"></p>
									</div>
									<div className="control-group col-sm-6">
										<label>Check-Out</label>
										<input
											type="text"
											className="form-control datetimepicker-input"
											id="date-2"
											data-toggle="datetimepicker"
											data-target="#date-2"
											placeholder="E.g. MM/DD/YYYY"
											required="required"
											data-validation-required-message="Please enter date"
										/>
										<p className="help-block text-danger"></p>
									</div>
								</div>
								<div className="control-group">
									<label>Special Request</label>
									<input
										type="text"
										className="form-control"
										id="request"
										placeholder="E.g. Special Request"
										required="required"
										data-validation-required-message="Please enter your special request"
									/>
									<p className="help-block text-danger"></p>
								</div>
								<div className="button">
									<button type="submit" id="bookingButton">
										Book Now
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
