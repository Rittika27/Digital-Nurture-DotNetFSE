PaymentContext context = new(new CreditCardPayment());
context.ExecutePayment(100.00);

context.SetStrategy(new PayPalPayment());
context.ExecutePayment(200.00);
