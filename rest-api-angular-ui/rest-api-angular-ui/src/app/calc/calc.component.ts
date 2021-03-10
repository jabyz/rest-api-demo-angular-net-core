import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared/shared.service';



@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styles: [
  ]
})
export class CalcComponent implements OnInit {

  constructor(private service:SharedService) { }

  value = 100;

  x:string="";
  y:string="";

  a:string="";
  s:string="";
  result:string="";

  ngOnInit(): void {
  }

  calc(){
    var val = {
      x:this.x,
      y:this.y,
    };

    this.service.getASum(val).subscribe((res:any)=>{
      this.a =res.myResult;
      var val2 = {
        a:this.a
      }
      this.service.getAProduct(val2).subscribe((res:any)=>{
        this.s = res.myResult;
        var val3 = {
          s:this.s
        }
        this.service.getAPower(val3).subscribe((res:any)=>{
          
          this.result = res.myResult;
        })
      })
    });

  }

}
