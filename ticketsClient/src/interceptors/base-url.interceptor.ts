import { HttpInterceptorFn } from '@angular/common/http';

export const baseUrlInterceptor: HttpInterceptorFn = (req, next) => {

  const baseUrl = 'http://localhost:5051/api/'; 
  const apiReq = req.clone({ url: `${baseUrl}${req.url}` });
  return next(apiReq);
};
