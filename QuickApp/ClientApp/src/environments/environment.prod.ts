
export const environment = {
    production: true,
	baseUrl: 'https://18.139.114.138/api', // Change this to the address of your backend API if different from frontend address
    tokenUrl: '/connect/token', // For IdentityServer/Authorization Server API. You can set to null if same as baseUrl
    loginUrl: '/login'
};
