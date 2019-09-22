using NestedCollectionView.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace NestedCollectionView.ViewModel
{
    public class CompanyViewModel:INotifyPropertyChanged
    {
        #region Property
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<CompanyModel> _companyList = null;
        public ObservableCollection<CompanyModel> CompanyList
        {
            get
            {
                if(_companyList == null)
                {
                    _companyList = new ObservableCollection<CompanyModel>();
                }
                return _companyList;
            }
            set { _companyList = value; }
        }

        #endregion

        #region Constructor
        public CompanyViewModel()
        {
            ProductModel productModel = new ProductModel() { ProductLogo = "car.jpg", ProductName = "Margrenta 1" };
            ProductModel productModel1 = new ProductModel() { ProductLogo = "car1.jpg", ProductName = "Margrenta 2" };

            ProductModel productModel2 = new ProductModel() { ProductLogo = "car2.jpg", ProductName = "KWID 1" };
            ProductModel productModel3 = new ProductModel() { ProductLogo = "car3.jpg", ProductName = "KWID 2" };

            CompanyModel companyModel = new CompanyModel() { CompanyLogo= "margrenta.jpg", CompanyName="Margrenta ",ProductList=new ObservableCollection<ProductModel>() { productModel, productModel1, productModel2, productModel3, productModel, productModel1, productModel2, productModel3 } };
            CompanyModel companyModel1 = new CompanyModel() { CompanyLogo = "volkswagen.jpg", CompanyName = "Volkswagen ", ProductList = new ObservableCollection<ProductModel>() { productModel2, productModel3 } };

            CompanyModel companyModel2 = new CompanyModel() { CompanyLogo = "margrenta.jpg", CompanyName = "Margrenta ", ProductList = new ObservableCollection<ProductModel>() { productModel, productModel1, productModel2, productModel3, productModel, productModel1, productModel2, productModel3 } };
            CompanyModel companyModel3 = new CompanyModel() { CompanyLogo = "volkswagen.jpg", CompanyName = "Volkswagen ", ProductList = new ObservableCollection<ProductModel>() { productModel2, productModel3 } };

            CompanyModel companyModel4 = new CompanyModel() { CompanyLogo = "margrenta.jpg", CompanyName = "Margrenta ", ProductList = new ObservableCollection<ProductModel>() { productModel, productModel1, productModel2, productModel3, productModel, productModel1, productModel2, productModel3 } };
            CompanyModel companyModel5 = new CompanyModel() { CompanyLogo = "volkswagen.jpg", CompanyName = "Volkswagen ", ProductList = new ObservableCollection<ProductModel>() { productModel2, productModel3 } };

            CompanyModel companyModel6 = new CompanyModel() { CompanyLogo = "margrenta.jpg", CompanyName = "Margrenta ", ProductList = new ObservableCollection<ProductModel>() { productModel, productModel1, productModel2, productModel3, productModel, productModel1, productModel2, productModel3 } };
            CompanyModel companyModel7 = new CompanyModel() { CompanyLogo = "volkswagen.jpg", CompanyName = "Volkswagen ", ProductList = new ObservableCollection<ProductModel>() { productModel2, productModel3 } };


            CompanyList.Add(companyModel);
            CompanyList.Add(companyModel1);
            CompanyList.Add(companyModel2);
            CompanyList.Add(companyModel3);
            CompanyList.Add(companyModel4);
            CompanyList.Add(companyModel5);
            CompanyList.Add(companyModel6);
            CompanyList.Add(companyModel7);
        }
        #endregion

        #region INotifyPropertyChanged

        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName]string propertyName = "", Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;
            changed?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}

