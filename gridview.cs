//Adding items to a list and binding it with a grid

 public class NonPTILineItemList
    {
        public string CarInitialAndNumber { get; set; }
        public string CRBInvoiceId { get; set; }
        public bool OnHold { get; set; }
        public bool CreatePTILineItem { get; set; }
        public bool ProceedWithoutPTILineItem { get; set; }

    }
    List<NonPTILineItemList> NonPTILineItemList = new List<NonPTILineItemList>();
NonPTILineItemList.Add(new NonPTILineItemList
                            {
                                CarInitialAndNumber = carDetails,
                                CRBInvoiceId = crbInvoiceId,
                                OnHold = false,
                                CreatePTILineItem = false,
                                ProceedWithoutPTILineItem = true
                            });
                            
    gvNonPTIList.DataSource = nonPTIcars; //list returned from the function to bind with gridView
            gvNonPTIList.DataBind();                        
