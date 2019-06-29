import React from 'react';

const RateList = ({ loading, error, data }) => {
	if (loading) return <p>Loading...</p>;
	if (error) return <p>Error :( </p>;

	return (
		<div>
			{data.rates.map(rate => (
				<li key={rate.currency}>{rate.currency + ' ' + rate.rate}</li>
			))}
		</div>
	);
};

export default RateList;
