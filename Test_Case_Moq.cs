[TestMethod()]
        public void GetRepairClassList_PassedCategoryName_ReturnsDictionary()
        {
            MaintenanceTypeDetailData maintenanceTypeDetailData = new MaintenanceTypeDetailData() { MaintenanceTypeId = 1, MaintenanceTypeCategoryId = 2, MaintenanceTypeCode = "U", MaintenanceTypeName = "UBS", MaintenanceTypeDescription = "UBS" };
            Collection<MaintenanceTypeDetailData> result = new Collection<MaintenanceTypeDetailData>();
            result.Add(maintenanceTypeDetailData);
            
            //creating mock object
            var ubsAccessManagerMock = new Mock<IUBSAccessManager>();
            //Setup method for setting expectations on mock object
            ubsAccessManagerMock.Setup(x => x.GetMaintenanceTypeDetailByCategoryName(It.IsAny<string>())).Returns(result);

            BillHeaderProcessor.UBSAccessManager = ubsAccessManagerMock.Object;
            
            //Method to be tested
            Dictionary<int, string> actualResult = BillHeaderProcessor.GetRepairClassList("abc");
            var keyValuePair = actualResult.FirstOrDefault();
            
            //Assert for checking the returned result
            Assert.AreEqual(result[0].MaintenanceTypeId, keyValuePair.Key);
            Assert.AreEqual(result[0].MaintenanceTypeName, keyValuePair.Value);
        }
