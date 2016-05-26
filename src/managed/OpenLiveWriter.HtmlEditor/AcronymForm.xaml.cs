using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OpenLiveWriter.HtmlEditor
{
    /// <summary>
    /// Interaction logic for AcronymForm.xaml
    /// </summary>
    public partial class AcronymForm
    {
        private readonly AcronymFormViewModel _model;

        public AcronymForm()
        {
            InitializeComponent();

            _model = new AcronymFormViewModel()
            {
                Acronym = "TLA"
            };

            DataContext = _model;
        }

        public AcronymForm(AcronymFormViewModel model)
        {
            InitializeComponent();

            _model = model;
            DataContext = _model;
        }

        protected override void OnSourceInitialized(EventArgs e)
        {
            IconHelper.RemoveIcon(this);
            base.OnSourceInitialized(e);
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
