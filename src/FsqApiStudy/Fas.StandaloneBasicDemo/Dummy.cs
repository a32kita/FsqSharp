using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// エンティティ確認用コード (コンパイル対象外)

public class Rootobject
{
    public Meta meta { get; set; }
    public Notification[] notifications { get; set; }
    public Response response { get; set; }
}

public class Meta
{
    public int code { get; set; }
    public string requestId { get; set; }
}

public class Response
{
    public User user { get; set; }
}

public class User
{
    public string id { get; set; }
    public string firstName { get; set; }
    public string gender { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string countryCode { get; set; }
    public string relationship { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public Photo photo { get; set; }
    public Friends friends { get; set; }
    public int birthday { get; set; }
    public bool isAnonymous { get; set; }
    public Tips1 tips { get; set; }
    public string homeCity { get; set; }
    public string bio { get; set; }
    public Contact1 contact { get; set; }
    public Photos photos { get; set; }
    public string checkinPings { get; set; }
    public bool pings { get; set; }
    public string type { get; set; }
    public Mayorships mayorships { get; set; }
    public Checkins checkins { get; set; }
    public Requests requests { get; set; }
    public Lists1 lists { get; set; }
    public string blockedStatus { get; set; }
    public int createdAt { get; set; }
    public object[] lenses { get; set; }
    public string referralId { get; set; }
}

public class Photo
{
    public string prefix { get; set; }
    public string suffix { get; set; }
}

public class Friends // => FsqFriendGroupCollection
{
    public int count { get; set; }
    public Group[] groups { get; set; }
}

public class Group // => FsqFriendGroup
{
    public string type { get; set; }
    public string name { get; set; }
    public int count { get; set; }
    public Item[] items { get; set; }
}

public class Item // => FsqUser (再利用)
{
    public string id { get; set; }
    public string firstName { get; set; }
    public string gender { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string countryCode { get; set; }
    public string relationship { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public Photo1 photo { get; set; }
    public bool isAnonymous { get; set; }
    public Tips tips { get; set; }
    public Lists lists { get; set; }
    public string homeCity { get; set; }
    public string bio { get; set; }
    public Contact contact { get; set; }
    public string lastName { get; set; }
}

public class Photo1
{
    public string prefix { get; set; }
    public string suffix { get; set; }
}

public class Tips
{
    public int count { get; set; }
}

public class Lists
{
    public Group1[] groups { get; set; }
}

public class Group1
{
    public string type { get; set; }
    public int count { get; set; }
    public object[] items { get; set; }
}

public class Contact
{
    public string twitter { get; set; }
    public string facebook { get; set; }
    public string email { get; set; }
}

public class Tips1
{
    public int count { get; set; }
}

public class Contact1
{
    public string verifiedPhone { get; set; }
    public string email { get; set; }
    public string twitter { get; set; }
}

public class Photos
{
    public int count { get; set; }
    public Item1[] items { get; set; }
}

public class Item1
{
    public string id { get; set; }
    public int createdAt { get; set; }
    public Source source { get; set; }
    public string prefix { get; set; }
    public string suffix { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string visibility { get; set; }
    public Venue venue { get; set; }
    public Checkin checkin { get; set; }
}

public class Source
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Venue
{
    public string id { get; set; }
    public string name { get; set; }
    public Contact2 contact { get; set; }
    public Location location { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public Category[] categories { get; set; }
    public bool verified { get; set; }
    public Stats stats { get; set; }
    public bool like { get; set; }
    public bool venueRatingBlacklisted { get; set; }
    public Beenhere beenHere { get; set; }
}

public class Contact2
{
}

public class Location
{
    public string address { get; set; }
    public float lat { get; set; }
    public float lng { get; set; }
    public Labeledlatlng[] labeledLatLngs { get; set; }
    public string cc { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public string contextLine { get; set; }
    public long contextGeoId { get; set; }
    public string[] formattedAddress { get; set; }
}

public class Labeledlatlng
{
    public string label { get; set; }
    public float lat { get; set; }
    public float lng { get; set; }
}

public class Stats
{
    public int tipCount { get; set; }
    public int usersCount { get; set; }
    public int checkinsCount { get; set; }
}

public class Beenhere
{
    public int lastCheckinExpiredAt { get; set; }
}

public class Category
{
    public string id { get; set; }
    public string name { get; set; }
    public string pluralName { get; set; }
    public string shortName { get; set; }
    public Icon icon { get; set; }
    public bool primary { get; set; }
}

public class Icon
{
    public string prefix { get; set; }
    public string mapPrefix { get; set; }
    public string suffix { get; set; }
}

public class Checkin
{
    public string id { get; set; }
    public int createdAt { get; set; }
    public string type { get; set; }
    public object[] entities { get; set; }
    public string shout { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public int timeZoneOffset { get; set; }
}

public class Mayorships
{
    public int count { get; set; }
    public object[] items { get; set; }
}

public class Checkins
{
    public int count { get; set; }
    public Item2[] items { get; set; }
}

public class Item2
{
    public string id { get; set; }
    public int createdAt { get; set; }
    public string type { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public int timeZoneOffset { get; set; }
    public Venue1 venue { get; set; }
    public Likes likes { get; set; }
    public bool like { get; set; }
    public bool isMayor { get; set; }
    public Photos1 photos { get; set; }
    public Posts posts { get; set; }
    public Comments comments { get; set; }
    public Source1 source { get; set; }
}

public class Venue1
{
    public string id { get; set; }
    public string name { get; set; }
    public Contact3 contact { get; set; }
    public Location1 location { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public Category1[] categories { get; set; }
    public bool verified { get; set; }
    public Stats1 stats { get; set; }
    public string url { get; set; }
    public string urlSig { get; set; }
    public bool like { get; set; }
    public bool allowMenuUrlEdit { get; set; }
    public Beenhere1 beenHere { get; set; }
}

public class Contact3
{
    public string phone { get; set; }
    public string formattedPhone { get; set; }
    public string twitter { get; set; }
    public string instagram { get; set; }
    public string facebook { get; set; }
    public string facebookUsername { get; set; }
    public string facebookName { get; set; }
}

public class Location1
{
    public string address { get; set; }
    public float lat { get; set; }
    public float lng { get; set; }
    public Labeledlatlng1[] labeledLatLngs { get; set; }
    public string postalCode { get; set; }
    public string cc { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public string contextLine { get; set; }
    public long contextGeoId { get; set; }
    public string[] formattedAddress { get; set; }
}

public class Labeledlatlng1
{
    public string label { get; set; }
    public float lat { get; set; }
    public float lng { get; set; }
}

public class Stats1
{
    public int tipCount { get; set; }
    public int usersCount { get; set; }
    public int checkinsCount { get; set; }
}

public class Beenhere1
{
    public int lastCheckinExpiredAt { get; set; }
}

public class Category1
{
    public string id { get; set; }
    public string name { get; set; }
    public string pluralName { get; set; }
    public string shortName { get; set; }
    public Icon1 icon { get; set; }
    public bool primary { get; set; }
}

public class Icon1
{
    public string prefix { get; set; }
    public string mapPrefix { get; set; }
    public string suffix { get; set; }
}

public class Likes
{
    public int count { get; set; }
    public object[] groups { get; set; }
}

public class Photos1
{
    public int count { get; set; }
    public object[] items { get; set; }
}

public class Posts
{
    public int count { get; set; }
    public int textCount { get; set; }
}

public class Comments
{
    public int count { get; set; }
}

public class Source1
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Requests
{
    public int count { get; set; }
}

public class Lists1
{
    public int count { get; set; }
    public Group2[] groups { get; set; }
}

public class Group2
{
    public string type { get; set; }
    public int count { get; set; }
    public Item3[] items { get; set; }
}

public class Item3
{
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string placesSummary { get; set; }
    public bool editable { get; set; }
    public bool _public { get; set; }
    public bool collaborative { get; set; }
    public string url { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public int createdAt { get; set; }
    public int updatedAt { get; set; }
    public Followers followers { get; set; }
    public Listitems listItems { get; set; }
    public string type { get; set; }
}

public class Followers
{
    public int count { get; set; }
}

public class Listitems
{
    public int count { get; set; }
}

public class Notification
{
    public string type { get; set; }
    public Item4 item { get; set; }
}

public class Item4
{
    public int unreadCount { get; set; }
}

