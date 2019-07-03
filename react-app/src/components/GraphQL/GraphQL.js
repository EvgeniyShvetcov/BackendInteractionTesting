import { Query, ApolloProvider } from 'react-apollo';
import ApolloClient, { gql } from 'apollo-boost';
import React from 'react';
import { StudentList } from './RateList';
import { useFetch } from '../../helpers/useFetch';

const client = new ApolloClient({
	uri: 'http://localhost:5000/graphql',
});
const studentListQuery = gql`
	query Students($studentId: ID) {
		students(studentId: $studentId) {
			id
			name: fullName
			date: enrollmentDate
		}
	}
`;

const GraphQL = ({ match }) => {
	return (
		<ApolloProvider client={client}>
			<Query
				query={studentListQuery}
				variables={{ studentId: match.params.studentId }}
			>
				{queryProps => <StudentList {...queryProps} />}
			</Query>
		</ApolloProvider>
	);
};

export default GraphQL;
