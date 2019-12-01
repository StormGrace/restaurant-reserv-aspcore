import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
    loginForm: FormGroup;
    constructor(private formBuilder: FormBuilder) { }

    ngOnInit(): void {
        this.loginForm = this.generateLoginForm();
    }

    onLoginButtonClicked(): void {
        if (this.loginForm.valid) {
            
            console.log('Do request with: ', this.loginForm.value);
        }
        else {
            this.loginForm.markAllAsTouched();
        }
    }

    private generateLoginForm(): FormGroup {
        let emailFormControl = this.formBuilder.control(null, [
            Validators.required,
            Validators.email 
        ]);

        let passwordFormControl = this.formBuilder.control(null, [
            Validators.required,
            Validators.minLength(5)
        ]);

        return this.formBuilder.group({
            email: emailFormControl,
            password: passwordFormControl
        });
    }
}
