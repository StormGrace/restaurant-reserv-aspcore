import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {
    registerForm: FormGroup;
    constructor(private formBuilder: FormBuilder) { }

    ngOnInit() {
        this.registerForm = this.generateRegisterForm();
  }
    onRegisterButtonClicked(): void {
        if (this.registerForm.valid) {

            console.log('Do request with: ', this.registerForm.value);
        }
        else {
            this.registerForm.markAllAsTouched();
        }
    }
    private generateRegisterForm(): FormGroup {
        let emailFormControl = this.formBuilder.control(null, [
            Validators.required,
            Validators.email
        ]);

        let passwordFormControl = this.formBuilder.control(null, [
            Validators.required,
            Validators.minLength(5)
        ]);
        let firstnameFormControl = this.formBuilder.control(null, [
            Validators.required,
        ]);
        let lastnameFormControl = this.formBuilder.control(null, [
            Validators.required,
        ]);

        return this.formBuilder.group({
            email: emailFormControl,
            password: passwordFormControl,
            first_name: firstnameFormControl,
            last_name: lastnameFormControl
        });
    }

}
