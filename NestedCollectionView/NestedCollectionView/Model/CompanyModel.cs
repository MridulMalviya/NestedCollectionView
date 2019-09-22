using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NestedCollectionView.Model
{
    public class CompanyModel
    {
        public string CompanyLogo { get; set; }
        public string CompanyName { get; set; }
       public ProductModel[]  ProductList { get; set; }
        //private ObservableCollection<ProductModel> _productList = null;
        //public ObservableCollection<ProductModel> ProductList
        //{
        //    get
        //    {
        //        if (_productList == null)
        //        {
        //            _productList = new ObservableCollection<ProductModel>();
        //        }
        //        return _productList;
        //    }
        //    set { _productList = value; }
        //}

    }
}
