import React from '../../node_modules/react';
import { Switch, Route } from 'react-router-dom';
import './App.css';
import NavMenu from './NavMenu';
import GraphQL from './GraphQL/GraphQL';
import RestApi from './RestApi';
import OData from './OData';

function App() {
	return (
		<React.Fragment>
			<NavMenu />
			<Switch>
				<Route path="/GraphQL/:studentId?" component={GraphQL} />
				<Route path="/RestApi" component={RestApi} />
				<Route path="/OData" component={OData} />
			</Switch>
		</React.Fragment>
	);
}

export default App;
