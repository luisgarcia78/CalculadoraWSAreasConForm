﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculadoraWSAreas.SWCalcularAreas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SWCalcularAreas.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaCuadrado", ReplyAction="*")]
        decimal AreaCuadrado(decimal L1, decimal L2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaCuadrado", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> AreaCuadradoAsync(decimal L1, decimal L2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaTriangulo", ReplyAction="*")]
        decimal AreaTriangulo(decimal basee, decimal altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaTriangulo", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> AreaTrianguloAsync(decimal basee, decimal altura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaCirculo", ReplyAction="*")]
        double AreaCirculo(double radio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AreaCirculo", ReplyAction="*")]
        System.Threading.Tasks.Task<double> AreaCirculoAsync(double radio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : CalculadoraWSAreas.SWCalcularAreas.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<CalculadoraWSAreas.SWCalcularAreas.WebService1Soap>, CalculadoraWSAreas.SWCalcularAreas.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal AreaCuadrado(decimal L1, decimal L2) {
            return base.Channel.AreaCuadrado(L1, L2);
        }
        
        public System.Threading.Tasks.Task<decimal> AreaCuadradoAsync(decimal L1, decimal L2) {
            return base.Channel.AreaCuadradoAsync(L1, L2);
        }
        
        public decimal AreaTriangulo(decimal basee, decimal altura) {
            return base.Channel.AreaTriangulo(basee, altura);
        }
        
        public System.Threading.Tasks.Task<decimal> AreaTrianguloAsync(decimal basee, decimal altura) {
            return base.Channel.AreaTrianguloAsync(basee, altura);
        }
        
        public double AreaCirculo(double radio) {
            return base.Channel.AreaCirculo(radio);
        }
        
        public System.Threading.Tasks.Task<double> AreaCirculoAsync(double radio) {
            return base.Channel.AreaCirculoAsync(radio);
        }
    }
}
