namespace MetaMood.Services
{
    public class CalculateService
    {
        public static int GetPageCount(int numItems, int pageSz)
        {
            // Set PageCount equal to how many pages it would take to display numRecords
            int PageCount = numItems / pageSz;

            // If there are remaining records that would not fill up an entire page, add another page
            if (numItems % pageSz != 0)
            {
                PageCount++;
            }

            return PageCount;
        }
    }
}
