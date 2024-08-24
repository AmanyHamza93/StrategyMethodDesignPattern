using StrategyMethodDesignPattern;

PaymentContext paymentContext = new PaymentContext(new PayPalPayment());

paymentContext.ProcessPayment(100.0f);

// Switching the payment method at runtime
paymentContext.SetPaymentStrategy(new BitcoinPayment());
paymentContext.ProcessPayment(50.0f);