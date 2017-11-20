using Android.OS;
using Android.Runtime;
using Android.Views;
using Fragment = Android.Support.V4.App.Fragment;
using R = OneMoreFabMenuDemo.Resource;

namespace OneMoreFabMenuDemo
{
	/// <summary>A placeholder fragment containing a simple view.</summary>
	[Register("id.karamunting.onemorefabmenudemo.MainActivityFragment")]
	public class MainActivityFragment : Fragment
	{
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
            => inflater.Inflate(R.Layout.fragment_main, container, false);
	}
}
