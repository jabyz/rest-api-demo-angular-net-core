import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  readonly APIUrl = "http://localhost:5000/api";
  constructor(private http:HttpClient) { }
  getASum(formData:any){
    return this.http.post(this.APIUrl + '/Func/getASum',formData);
  }
  getAProduct(formData:any){
    return this.http.post(this.APIUrl + '/Func/getAProduct',formData);
  }
  getAPower(formData:any){
    return this.http.post(this.APIUrl + '/Func/getAPower',formData);
  }
}