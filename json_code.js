//JS file code to work with JSON object
 var CarsInfo = HiddenFieldCarsInfo.Get("OriginallyCheckedCars");
                        var obj = JSON.parse(CarsInfo);
                        for (var i = 0; i < count; i++) {
                           
                            var radioButtonWithoutPTI = eval('rdbSubmitWithoutPTIrb_' + i.toString());
                            var radioButtonOnHold = eval('rdbOnHoldrb_' + i.toString());
                            var radioButtonCreatePTI = eval('rdbCreatePTIrb_' + i.toString());
                            var InvoiceId = gvNonPTIList.GetRow(i).children[4].getElementsByTagName("input")[0].value;
                            if (radioButtonWithoutPTI.GetChecked()) {
                                for (var key in obj) {
                                    if (InvoiceId == obj[key].CRBInvoiceId) {
                                        obj[key].CreatePTIValue = 'N';
                                        break;
                                    }
                                }
                            }
                            else if (radioButtonOnHold.GetChecked()) {
                                for (var key in obj) {
                                    if (InvoiceId == obj[key].CRBInvoiceId) {
                                        obj.splice(key, 1);
                                        break;
                                    }
                                }
                            }
                            else if (radioButtonCreatePTI.GetChecked()) {
                                for (var key in obj) {
                                    if (InvoiceId == obj[key].CRBInvoiceId) {
                                        obj[key].CreatePTIValue = 'Y';
                                        break;
                                    }
                                }

                            }
                        }
