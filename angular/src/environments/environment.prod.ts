import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'MuestraLeptonX',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44382',
    redirectUri: baseUrl,
    clientId: 'MuestraLeptonX_App',
    responseType: 'code',
    scope: 'offline_access MuestraLeptonX',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44382',
      rootNamespace: 'MuestraLeptonX',
    },
  },
} as Environment;
