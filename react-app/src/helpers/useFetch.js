import { useEffect, useState } from 'react';

export const useFetch = url => {
	const [state, setState] = useState({
		data: null,
		loading: true,
		errors: null,
	});

	useEffect(() => {
		setState({ data: null, loading: true, errors: null });
		fetch(url)
			.then(response => {
				if (response.ok) return response.json();
			})
			.then(data => {
				if (data.errors) setState({ errors: data.errors });
				else setState({ data, loading: false, errors: null });
			});
	}, [url]);

	return state;
};
