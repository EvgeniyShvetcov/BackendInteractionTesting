import { Query, ApolloProvider } from 'react-apollo';
import ApolloClient, { gql } from 'apollo-boost';
import React from 'react';
import RateList from './RateList';

const client = new ApolloClient({
	uri: 'https://48p1r2roz4.sse.codesandbox.io/',
});
const ratesListQuery = gql`
	query Rates($currency: String!) {
		rates(currency: $currency) {
			currency
			rate
		}
	}
`;

const GraphQL = ({ match }) => {
	return (
		<ApolloProvider client={client}>
			<Query
				query={ratesListQuery}
				variables={{ currency: match.params.currency }}
			>
				{queryProps => <RateList {...queryProps} />}
			</Query>
		</ApolloProvider>
	);
};

export default GraphQL;
