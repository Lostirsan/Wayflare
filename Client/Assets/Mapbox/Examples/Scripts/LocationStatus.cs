namespace Mapbox.Examples
{
	using Mapbox.Unity.Location;
	using Mapbox.Utils;
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;
	using UnityEngine.UI;

	public class LocationStatus : MonoBehaviour
	{

		[SerializeField]
		Text _statusText;

		Location currLoc;

		private AbstractLocationProvider _locationProvider = null;
		bool loaded = false;
		void Start()
		{	
		}


		void Update()
		{
			if (loaded)
			{
				currLoc = _locationProvider.CurrentLocation;
			}
		}

		public void load()
		{
			if (!loaded)
			{
				loaded = true;
				if (null == _locationProvider)
				{
					_locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider as AbstractLocationProvider;
				}
			}
        }


		public double GetLocationLat()
		{
			return currLoc.LatitudeLongitude.x;
		}

		public double GetLocationLon()
        {
			return currLoc.LatitudeLongitude.y;
        }
	}
}
