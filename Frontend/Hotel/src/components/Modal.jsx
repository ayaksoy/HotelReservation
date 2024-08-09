import React from "react";

export default function Modal() {
	return (
		<>
			<div id="modal-id" className="modal fade" tabindex="-1" role="dialog">
				<div className="modal-dialog modal-lg">
					<div className="modal-content">
						<div className="modal-header">
							<button type="button" className="close" data-dismiss="modal">
								&times;
							</button>
						</div>
						<div className="modal-body">
							<div className="row">
								<div className="col-12">
									<div className="port-slider">
										<div>
											<img src="img/room-slider/room-1.jpg" />
										</div>
										<div>
											<img src="img/room-slider/room-2.jpg" />
										</div>
										<div>
											<img src="img/room-slider/room-3.jpg" />
										</div>
										<div>
											<img src="img/room-slider/room-4.jpg" />
										</div>
										<div>
											<img src="img/room-slider/room-5.jpg" />
										</div>
										<div>
											<img src="img/room-slider/room-6.jpg" />
										</div>
									</div>
									<div className="port-slider-nav">
										<div>
											<img src="img/room-slider/room-1.jpg" />
										</div>
										<div>
											<img src="img/room-slider/room-2.jpg" />
										</div>
										<div>
											<img src="img/room-slider/room-3.jpg" />
										</div>
										<div>
											<img src="img/room-slider/room-4.jpg" />
										</div>
										<div>
											<img src="img/room-slider/room-5.jpg" />
										</div>
										<div>
											<img src="img/room-slider/room-6.jpg" />
										</div>
									</div>
								</div>
								<div className="col-12">
									<h2>Lorem ipsum dolor</h2>
									<p>
										Lorem ipsum dolor viverra purus imperdiet rhoncus imperdiet.
										Suspendisse vulputate condimentum ligula sollicitudin
										hendrerit. Phasellus luctus, elit et ultrices interdum,
										neque mi pellentesque massorci. Nam in cursus ex, nec mattis
										lectus. Curabitur quis elementum nunc. Mauris iaculis, justo
										eu aliquam sagittis, arcu eros cursus libero, sit amet
										eleifend dolor odio at lacus.
									</p>
									<div className="modal-link">
										<a href="#">Book Now</a>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</>
	);
}
