"use strict";

// Class Definition
var KTLogin = function() {
	var _buttonSpinnerClasses = 'spinner spinner-right spinner-white pr-15';

	var _handleFormSignin = function() {
		var form = KTUtil.getById('kt_login_singin_form');
		var formSubmitUrl = KTUtil.attr(form, 'action');
		var formSubmitButton = KTUtil.getById('kt_login_singin_form_submit_button');

		if (!form) {
			return;
		}

		FormValidation
		    .formValidation(
		        form,
		        {
		            fields: {
						Email: {
							validators: {
								notEmpty: {
									message: 'E-mail is required'
								}
							}
						},
						Sifre: {
							validators: {
								notEmpty: {
									message: 'Password is required'
								}
							}
						}
		            },
		            plugins: {
						trigger: new FormValidation.plugins.Trigger(),
						submitButton: new FormValidation.plugins.SubmitButton(),
	            		defaultSubmit: new FormValidation.plugins.DefaultSubmit(), // Uncomment this line to enable normal button submit after form validation
						bootstrap: new FormValidation.plugins.Bootstrap({
						//	eleInvalidClass: '', // Repace with uncomment to hide bootstrap validation icons
						//	eleValidClass: '',   // Repace with uncomment to hide bootstrap validation icons
						})
		            }
		        }
		    )
		    .on('core.form.valid', function() {
				// Show loading state on button
				KTUtil.btnWait(formSubmitButton, _buttonSpinnerClasses, "Lütfen Bekleyin");
					
				 //Simulate Ajax request
				setTimeout(function() {
					KTUtil.btnRelease(formSubmitButton);
				}, 2000);
					
				// Form Validation & Ajax Submission: https://formvalidation.io/guide/examples/using-ajax-to-submit-the-form
				
		        formvalidation.utils.fetch(formsubmiturl, {
		            method: 'post',
					datatype: 'json',
		            params: {
		                name: form.queryselector('[name="Email"]').value,
		                email: form.queryselector('[name="Sifre"]').value,
		            },
		        }).then(function(response) { // return valid json
					// release button
					ktutil.btnrelease(formsubmitbutton);

							console.log("Burada => " + name);
							console.log("Burada 2 => " + email);

					if (response && typeof response === 'object' && response.status && response.status == 'success') {
						swal.fire({
			                text: "all is cool! now you submit this form",
			                icon: "success",
			                buttonsstyling: false,
							confirmbuttontext: "ok, got it!",
							customclass: {
								confirmbutton: "btn font-weight-bold btn-light-primary"
							}
			            }).then(function() {
							ktutil.scrolltop();
						});
					} else {
						swal.fire({
			                text: "sorry, something went wrong, please try again.",
			                icon: "error",
			                buttonsstyling: false,
							confirmbuttontext: "ok, got it!",
							customclass: {
								confirmbutton: "btn font-weight-bold btn-light-primary"
							}
			            }).then(function() {
							ktutil.scrolltop();
						});
					}
		        });
		    })
			.on('core.form.invalid', function() {
				Swal.fire({
					text: "Sorry, looks like there are some errors detected, please try again.",
					icon: "error",
					buttonsStyling: false,
					confirmButtonText: "Ok, got it!",
					customClass: {
						confirmButton: "btn font-weight-bold btn-light-primary"
					}
				}).then(function() {
					KTUtil.scrollTop();
				});
		    });
    }

	var _handleFormForgot = function() {
		var form = KTUtil.getById('kt_login_forgot_form');
		var formSubmitUrl = KTUtil.attr(form, 'action');
		var formSubmitButton = KTUtil.getById('kt_login_forgot_form_submit_button');

		if (!form) {
			return;
		}

		FormValidation
		    .formValidation(
		        form,
		        {
		            fields: {
						email: {
							validators: {
								notEmpty: {
									message: 'Email is required'
								},
								emailAddress: {
									message: 'The value is not a valid email address'
								}
							}
						}
		            },
		            plugins: {
						trigger: new FormValidation.plugins.Trigger(),
						submitButton: new FormValidation.plugins.SubmitButton(),
	            		//defaultSubmit: new FormValidation.plugins.DefaultSubmit(), // Uncomment this line to enable normal button submit after form validation
						bootstrap: new FormValidation.plugins.Bootstrap({
						//	eleInvalidClass: '', // Repace with uncomment to hide bootstrap validation icons
						//	eleValidClass: '',   // Repace with uncomment to hide bootstrap validation icons
						})
		            }
		        }
		    )
		    .on('core.form.valid', function() {
				// Show loading state on button
				KTUtil.btnWait(formSubmitButton, _buttonSpinnerClasses, "Please wait");

				// Simulate Ajax request
				setTimeout(function() {
					KTUtil.btnRelease(formSubmitButton);
				}, 2000);
		    })
			.on('core.form.invalid', function() {
				Swal.fire({
					text: "Sorry, looks like there are some errors detected, please try again.",
					icon: "error",
					buttonsStyling: false,
					confirmButtonText: "Ok, got it!",
					customClass: {
						confirmButton: "btn font-weight-bold btn-light-primary"
					}
				}).then(function() {
					KTUtil.scrollTop();
				});
		    });
    }

	var _handleFormSignup = function() {
		// Base elements
		var wizardEl = KTUtil.getById('kt_login');
		var form = KTUtil.getById('kt_login_signup_form');
		var wizardObj;
		var validations = [];

		if (!form) {
			return;
		}

		// Init form validation rules. For more info check the FormValidation plugin's official documentation:https://formvalidation.io/
		// Step 1
		validations.push(FormValidation.formValidation(
			form,
			{
				fields: {
					Email: {
						validators: {
							notEmpty: {
								message: 'Email alaný zorunludur!'
							},
							emailAddress: {
								message: 'Lütfen geçerli bir e-mail adresi giriniz!'
							}
						}
					},
					Password: {
						validators: {
							notEmpty: {
								message: 'Þifre alaný zorunludur!'
							}
						}
					},
					Password2: {
						validators: {
							notEmpty: {
								message: 'Þifre tekrar alaný zorunludur!'
							}
						}
					}
				},
				plugins: {
					trigger: new FormValidation.plugins.Trigger(),
					// Bootstrap Framework Integration
					bootstrap: new FormValidation.plugins.Bootstrap({
						//eleInvalidClass: '',
						eleValidClass: '',
					})
				}
			}
		));

		// Step 2
		validations.push(FormValidation.formValidation(
			form,
			{
				fields: {
					AdSoyad: {
						validators: {
							notEmpty: {
								message: 'Ad Soyad alaný zorunludur!'
							}
						}
					},
					Telefon: {
						validators: {
							notEmpty: {
								message: 'Telefon alaný zorunludur!'
							}
						}
					},
					KullaniciAdi: {
						validators: {
							notEmpty: {
								message: 'Kullanýcý Adý alaný zorunludur!'
							}
						}
					},
					DogumTarihi: {
						validators: {
							notEmpty: {
								message: 'Doðum Tarihi alaný zorunludur!'
							}
						}
					}
				},
				plugins: {
					trigger: new FormValidation.plugins.Trigger(),
					// Bootstrap Framework Integration
					bootstrap: new FormValidation.plugins.Bootstrap({
						//eleInvalidClass: '',
						eleValidClass: '',
					})
				}
			}
		));

		// Initialize form wizard
		wizardObj = new KTWizard(wizardEl, {
			startStep: 1, // initial active step number
			clickableSteps: false  // allow step clicking
		});

		// Validation before going to next page
		wizardObj.on('change', function (wizard) {
			if (wizard.getStep() > wizard.getNewStep()) {
				return; // Skip if stepped back
			}

			// Validate form before change wizard step
			var validator = validations[wizard.getStep() - 1]; // get validator for currnt step

			if (validator) {
				validator.validate().then(function (status) {
					if (status == 'Valid') {
						wizard.goTo(wizard.getNewStep());

						KTUtil.scrollTop();
					} else {
						Swal.fire({
							text: "Sorry, looks like there are some errors detected, please try again.",
							icon: "error",
							buttonsStyling: false,
							confirmButtonText: "Ok, got it!",
							customClass: {
								confirmButton: "btn font-weight-bold btn-light"
							}
						}).then(function () {
							KTUtil.scrollTop();
						});
					}
				});
			}

			return false;  // Do not change wizard step, further action will be handled by he validator
		});

		// Change event
		wizardObj.on('changed', function (wizard) {
			KTUtil.scrollTop();
		});

		// Submit event
		wizardObj.on('submit', function (wizard) {
			Swal.fire({
				text: "All is good! Please confirm the form submission.",
				icon: "success",
				showCancelButton: true,
				buttonsStyling: false,
				confirmButtonText: "Yes, submit!",
				cancelButtonText: "No, cancel",
				customClass: {
					confirmButton: "btn font-weight-bold btn-primary",
					cancelButton: "btn font-weight-bold btn-default"
				}
			}).then(function (result) {
				if (result.value) {
					form.submit(); // Submit form
				} else if (result.dismiss === 'cancel') {
					Swal.fire({
						text: "Your form has not been submitted!.",
						icon: "error",
						buttonsStyling: false,
						confirmButtonText: "Ok, got it!",
						customClass: {
							confirmButton: "btn font-weight-bold btn-primary",
						}
					});
				}
			});
		});
    }

    // Public Functions
    return {
        init: function() {
            _handleFormSignin();
			_handleFormForgot();
			_handleFormSignup();
        }
    };
}();

// Class Initialization
jQuery(document).ready(function() {
    KTLogin.init();
});
