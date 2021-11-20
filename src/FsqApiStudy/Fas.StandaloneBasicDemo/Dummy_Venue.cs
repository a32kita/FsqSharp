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
    public Venue venue { get; set; }
    public Pageconfig pageConfig { get; set; }
}

public class Venue
{
    public string id { get; set; }
    public string name { get; set; }
    public Contact contact { get; set; }
    public Location location { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public Category[] categories { get; set; }
    public bool verified { get; set; }
    public Stats stats { get; set; }
    public Likes likes { get; set; }
    public bool like { get; set; }
    public bool dislike { get; set; }
    public bool ok { get; set; }
    public bool venueRatingBlacklisted { get; set; }
    public Friendvisits friendVisits { get; set; }
    public Beenhere beenHere { get; set; }
    public Specials specials { get; set; }
    public Photos photos { get; set; }
    public Reasons reasons { get; set; }
    public Herenow hereNow { get; set; }
    public int createdAt { get; set; }
    public Tips tips { get; set; }
    public string shortUrl { get; set; }
    public string timeZone { get; set; }
    public Listed listed { get; set; }
    public object[] seasonalHours { get; set; }
    public Pageupdates pageUpdates { get; set; }
    public Structuredlocation[] structuredLocation { get; set; }
    public Permissions permissions { get; set; }
    public Inbox inbox { get; set; }
    public object[] venueChains { get; set; }
    public Attributes attributes { get; set; }
    public Bestphoto bestPhoto { get; set; }
    public string[] aliases { get; set; }
    public Metatags metaTags { get; set; }
}

public class Contact
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
    public int visitsCount { get; set; }
}

public class Likes
{
    public int count { get; set; }
    public object[] groups { get; set; }
}

public class Friendvisits
{
    public int count { get; set; }
    public string summary { get; set; }
    public Item[] items { get; set; }
}

public class Item
{
    public int visitedCount { get; set; }
    public bool liked { get; set; }
    public bool disliked { get; set; }
    public bool oked { get; set; }
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
    public bool isAnonymous { get; set; }
}

public class Photo
{
    public string prefix { get; set; }
    public string suffix { get; set; }
}

public class Beenhere
{
    public int count { get; set; }
    public int unconfirmedCount { get; set; }
    public bool marked { get; set; }
    public int lastVisitedAt { get; set; }
    public int lastCheckinExpiredAt { get; set; }
}

public class Specials
{
    public int count { get; set; }
    public object[] items { get; set; }
}

public class Photos
{
    public int count { get; set; }
    public Group[] groups { get; set; }
}

public class Group
{
    public string type { get; set; }
    public string name { get; set; }
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
    public User1 user { get; set; }
    public string visibility { get; set; }
}

public class Source
{
    public string name { get; set; }
    public string url { get; set; }
}

public class User1
{
    public string id { get; set; }
    public string firstName { get; set; }
    public string gender { get; set; }
    public string address { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string countryCode { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public Photo1 photo { get; set; }
    public bool isAnonymous { get; set; }
    public string lastName { get; set; }
    public string relationship { get; set; }
}

public class Photo1
{
    public string prefix { get; set; }
    public string suffix { get; set; }
}

public class Reasons
{
    public int count { get; set; }
    public Item2[] items { get; set; }
}

public class Item2
{
    public string summary { get; set; }
    public string pluralSummary { get; set; }
    public string type { get; set; }
    public string reasonName { get; set; }
    public Target target { get; set; }
    public int count { get; set; }
}

public class Target
{
    public string type { get; set; }
    public Object _object { get; set; }
}

public class Object
{
    public string id { get; set; }
    public string type { get; set; }
    public Target1 target { get; set; }
    public bool ignorable { get; set; }
}

public class Target1
{
    public string type { get; set; }
    public string url { get; set; }
}

public class Herenow
{
    public int count { get; set; }
    public string summary { get; set; }
    public object[] groups { get; set; }
}

public class Tips
{
    public int count { get; set; }
    public Group1[] groups { get; set; }
}

public class Group1
{
    public string type { get; set; }
    public string name { get; set; }
    public int count { get; set; }
    public Item3[] items { get; set; }
}

public class Item3
{
    public string id { get; set; }
    public int createdAt { get; set; }
    public string text { get; set; }
    public string type { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public Photo2 photo { get; set; }
    public string photourl { get; set; }
    public Likes1 likes { get; set; }
    public bool like { get; set; }
    public int viewCount { get; set; }
    public int agreeCount { get; set; }
    public int disagreeCount { get; set; }
    public Todo todo { get; set; }
    public User2 user { get; set; }
}

public class Photo2
{
    public string id { get; set; }
    public int createdAt { get; set; }
    public Source1 source { get; set; }
    public string prefix { get; set; }
    public string suffix { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string visibility { get; set; }
}

public class Source1
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Likes1
{
    public int count { get; set; }
    public object[] groups { get; set; }
}

public class Todo
{
    public int count { get; set; }
}

public class User2
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
    public Photo3 photo { get; set; }
    public bool isAnonymous { get; set; }
}

public class Photo3
{
    public string prefix { get; set; }
    public string suffix { get; set; }
}

public class Listed
{
    public int count { get; set; }
    public object[] groups { get; set; }
}

public class Pageupdates
{
    public int count { get; set; }
    public object[] items { get; set; }
}

public class Permissions
{
    public bool addTips { get; set; }
    public bool showPhotos { get; set; }
    public bool flagTips { get; set; }
    public bool editHours { get; set; }
    public bool editVenue { get; set; }
    public bool seeEditVenuePage { get; set; }
    public bool editCategories { get; set; }
    public bool viewEditHistory { get; set; }
    public bool viewGeoAdminPage { get; set; }
    public bool viewShapesAdminPage { get; set; }
    public bool viewSubvenueEditorAdminPage { get; set; }
    public bool viewEventsAdminPage { get; set; }
    public bool flagVenue { get; set; }
    public bool viewFlags { get; set; }
    public bool hasRestrictedAddress { get; set; }
    public bool indexable { get; set; }
    public bool isCreator { get; set; }
    public bool sendUpdates { get; set; }
    public bool canEditAttributes { get; set; }
    public bool usesState { get; set; }
    public bool usesAddress { get; set; }
    public bool usesPhone { get; set; }
    public bool canRollbackEdits { get; set; }
}

public class Inbox
{
    public int count { get; set; }
    public object[] items { get; set; }
}

public class Attributes
{
    public object[] groups { get; set; }
}

public class Bestphoto
{
    public string id { get; set; }
    public int createdAt { get; set; }
    public Source2 source { get; set; }
    public string prefix { get; set; }
    public string suffix { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public string visibility { get; set; }
}

public class Source2
{
    public string name { get; set; }
    public string url { get; set; }
}

public class Metatags
{
    public string description { get; set; }
    public string title { get; set; }
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

public class Structuredlocation
{
    public string cc { get; set; }
    public string name { get; set; }
    public int woeType { get; set; }
    public string longId { get; set; }
    public bool allowExplore { get; set; }
    public string displayName { get; set; }
    public string slug { get; set; }
    public bool hasCityPage { get; set; }
}

public class Pageconfig
{
    public bool hideTastepile { get; set; }
    public bool showSeeAllTipsButton { get; set; }
    public int tipCountMax { get; set; }
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
