using Microsoft.VisualStudio.TestTools.UnitTesting; 
using CalculatorApp.Services; 
namespace CalculatorApp.Services.Test {
    [TestClass]
    public class CalculatorTest {
        Calculator _calc; 
        public CalculatorTest() {
            _calc = new Calculator(); 
        }

        
        [TestMethod]
       public void shouldaddtwonumbers() {
           int res = _calc.Add(5, 3); 
           Assert.AreEqual(res, 8); 
       }
    }
}
