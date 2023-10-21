namespace FinalProjectFormsApp.Forms.OrderForms
{
    public class ItemListBoxRow
    {
        public int Id { get; set; }
        public string DisplayText { get; set; }

        public ItemListBoxRow()
        {

        }

        public ItemListBoxRow(int ıd, string displayText)
        {
            Id = ıd;
            DisplayText = displayText;
        }
    }
}
