using System;
using System.Collections.Generic;
using System.Text;
using Calculator.Models;

namespace Calculator.ViewModels
{
    public class OperationViewModel
    {
        public OperationModel NewOperation { get; set; }

        public OperationViewModel()
        {
            NewOperation = new OperationModel();
        }

        public void GetResult()
        {
            NewOperation.GetResult();
        }

    }
}
