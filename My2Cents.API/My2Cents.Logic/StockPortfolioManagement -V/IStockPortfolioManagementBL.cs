using My2Cents.DataInfrastructure;

namespace My2Cents.Logic.Interfaces
{
    public interface IStockPortfolioManagementBL
    {
        /// <summary>
        /// creates a new stock request
        /// </summary>
        /// <param name="s_stock"></param>
        /// <returns></returns>
        Stock AddNewStock(Stock s_stock);
        /// <summary>
        /// returns the list of ALL of the stocks
        /// </summary>
        /// <returns></returns>
        List<Stock> GetAllStocks();
        /*
        /// <summary>
        /// gets stock info from the stock's name
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<Stock> GetStockFromName(string stockName);
        */
        /// <summary>
        /// updates the stock status
        /// </summary>
        /// <param name="s_stock"></param>
        /// <returns></returns>
        Stock UpdateStockInformation(Stock s_stock);
        /// <summary>
        /// deletes the stock
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        Stock DeleteStock(int stockId);
        bool CheckDuplicateStock(string stockName);
        Stock CheckStockId(int stockId);


        // Stock User

    }
}