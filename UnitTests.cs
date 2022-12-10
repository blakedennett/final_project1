

namespace TestClass {

    
    public class UnitTest1 {
        public void testComputeTotal() {

            List<int> intitialValues = new List<int>();

            
            for (int i = 1; i <= 10; i++) { 

                var random = new Random();

                int index = random.Next(1, 100000);

                intitialValues.Add(index);

            }
            List<int> rateValues = new List<int>();

            
            for (int i = 1; i <= 10; i++) { 

                var random = new Random();

                int index = random.Next(1, 50);

                rateValues.Add(index);

            }
        
            List<int> yearValues = new List<int>();

            
            for (int i = 1; i <= 10; i++) { 

                var random = new Random();

                int index = random.Next(1, 100);

                yearValues.Add(index);

            }
          
        
            Invest invest = new Invest();

            var r1 = new Random();
            
            int i1 = r1.Next(intitialValues.Count);

            var r2 = new Random();
            
            int i2 = r2.Next(intitialValues.Count);

            var r3 = new Random();
            
            int i3 = r3.Next(intitialValues.Count);


            double total = invest.ComputeTotal(i1, i2, i3, 100);
           
        }



    }

}

