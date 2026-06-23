IPaymentProcessor[] processors = { new PayPalAdapter(), new StripeAdapter() };

foreach (var processor in processors)
    processor.ProcessPayment(250.00);
