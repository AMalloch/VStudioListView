using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Collections.Generic;

namespace ListViewTutorial
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        private List<Person> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            mListView = FindViewById<ListView>(Resource.Id.myListView);

            mItems = new List<Person>();

            mItems.Add(new Person() { FirstName = "Angus", LastName = "Malloch", Age = "31", Gender = "Male" });  
            mItems.Add(new Person() { FirstName = "Heather", LastName = "Malloch", Age = "33", Gender = "Female" });  
            mItems.Add(new Person() { FirstName = "Bonzo", LastName = "McBonzo", Age = "50", Gender = "Male" });  

            // ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

            mListView.Adapter = adapter;
        }
    }
}

