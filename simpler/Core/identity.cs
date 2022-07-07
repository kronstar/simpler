namespace simpler.Core
{
	public static class Identity
	{
		/// <summary>
		/// Return unique user id
		/// </summary>
		/// <returns>User id as a unique string</returns>
		public static string CreateUUID()
		{
			Guid myuuid = Guid.NewGuid();
			return myuuid.ToString();
		}

		/// <summary>
		/// Return product id
		/// </summary>
		/// <param name="value">Product name to generate id</param>
		/// <returns>Product id as a unique string</returns>
		public static string CreateProductID(string value)
		{
			return value;
		}
		/// <summary>
		/// Return Order id
		/// </summary>
		/// <param name="value">Order id returned</param>
		/// <returns>Order id as a unique string</returns>
		public static string CreateOrderID(string value)
		{
			string current_date = DateTime.Now.Ticks.ToString();
			return value;
		}
	}
}
