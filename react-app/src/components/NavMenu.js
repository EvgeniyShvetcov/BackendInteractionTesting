import React from 'react';
import { LinkContainer } from 'react-router-bootstrap';
import { Nav, Navbar } from 'react-bootstrap';

const NavMenu = () => {
	return (
		<React.Fragment>
			<Navbar bg="dark" variant="dark">
				<Navbar.Brand>Backend Interaction</Navbar.Brand>
				<Nav className="mr-auto">
					<LinkContainer to="/GraphQL">
						<Nav.Link>GraphQL</Nav.Link>
					</LinkContainer>
					<LinkContainer to="/RestAPI">
						<Nav.Link>RestAPI</Nav.Link>
					</LinkContainer>
					<LinkContainer to="/OData">
						<Nav.Link>OData</Nav.Link>
					</LinkContainer>
				</Nav>
			</Navbar>
		</React.Fragment>
	);
};

export default NavMenu;
