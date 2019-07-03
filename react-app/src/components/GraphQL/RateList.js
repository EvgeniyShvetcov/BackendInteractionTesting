import React from 'react';

export const StudentList = ({ loading, error, data }) => {
	if (loading) return <p>Loading...</p>;
	if (error) return <p>Error :( </p>;

	return (
		<div>
			{data.students.map(item => (
				<li key={item.id}>
					{item.name + ' EnrollmentDate:' + item.date}
				</li>
			))}
		</div>
	);
};
