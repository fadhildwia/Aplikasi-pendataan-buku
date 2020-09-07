namespace WindowsFormsApp1
{
    class Book
    {
        private string title;
        private string author;
        private int year;
        private string publisher;

        public string Title
        {
            set
            {
                if (value.Length == 0)
                    value = "No Title";

                title = value;
            }
            get
            {
                return title;
            }
        }

        public string Author
        {
            set
            {
                if (value.Length == 0)
                    value = "Anonymous";

                author = value;
            }
            get
            {
                return author;
            }

        }

        public int Year
        {
            set
            {
                if (value < 1)
                    value = 2000;

                year = value;
            }
            get
            {
                return year;
            }

        }

        public string Publisher
        {
            set
            {
                if (value.Length == 0)
                    value = "No Where";

                publisher = value;
            }
            get
            {
                return publisher;
            }

        }
    }
}
