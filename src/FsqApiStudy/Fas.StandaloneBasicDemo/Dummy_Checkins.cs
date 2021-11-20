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
    public Checkins checkins { get; set; }
}

public class Checkins
{
    public int count { get; set; }
    public Item[] items { get; set; }
}

public class Item
{
    public string id { get; set; }
    public int createdAt { get; set; }
    public string type { get; set; }
    public string canonicalUrl { get; set; }
    public string canonicalPath { get; set; }
    public int timeZoneOffset { get; set; }
    public Venue venue { get; set; }
    public Likes likes { get; set; }
    public bool like { get; set; }
    public bool isMayor { get; set; }
    public Photos photos { get; set; }
    public Posts posts { get; set; }
    public Comments comments { get; set; }
    public Source1 source { get; set; }
    public object[] entities { get; set; }
    public string shout { get; set; }
    public Sticker sticker { get; set; }
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
    public string url { get; set; }
    public string urlSig { get; set; }
    public bool allowMenuUrlEdit { get; set; }
    public Beenhere beenHere { get; set; }
    public bool venueRatingBlacklisted { get; set; }
    public Menu menu { get; set; }
    public bool locked { get; set; }
}

public class Contact
{
    public string phone { get; set; }
    public string formattedPhone { get; set; }
    public string twitter { get; set; }
    public string instagram { get; set; }
    public string facebook { get; set; }
    public string facebookUsername { get; set; }
    public string facebookName { get; set; }
}

public class Location
{
    public string address { get; set; }
    public float lat { get; set; }
    public float lng { get; set; }
    public Labeledlatlng[] labeledLatLngs { get; set; }
    public string postalCode { get; set; }
    public string cc { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public string contextLine { get; set; }
    public long contextGeoId { get; set; }
    public string[] formattedAddress { get; set; }
    public string neighborhood { get; set; }
    public string crossStreet { get; set; }
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

public class Menu
{
    public string type { get; set; }
    public string label { get; set; }
    public string anchor { get; set; }
    public string url { get; set; }
    public string mobileUrl { get; set; }
    public string canonicalPath { get; set; }
    public string externalUrl { get; set; }
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

public class Likes
{
    public int count { get; set; }
    public Group[] groups { get; set; }
    public string summary { get; set; }
}

public class Group
{
    public string type { get; set; }
    public int count { get; set; }
    public Item1[] items { get; set; }
}

public class Item1
{
    public string id { get; set; }
    public string firstName { get; set; }
    public string gender { get; set; }
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

public class Photos
{
    public int count { get; set; }
    public Item2[] items { get; set; }
    public Layout layout { get; set; }
}

public class Layout
{
    public string name { get; set; }
}

public class Item2
{
    public string id { get; set; }
    public int createdAt { get; set; }
    public Source source { get; set; }
    public string prefix { get; set; }
    public string suffix { get; set; }
    public int width { get; set; }
    public int height { get; set; }
    public User user { get; set; }
    public string visibility { get; set; }
}

public class Source
{
    public string name { get; set; }
    public string url { get; set; }
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
    public Photo1 photo { get; set; }
    public bool isAnonymous { get; set; }
}

public class Photo1
{
    public string prefix { get; set; }
    public string suffix { get; set; }
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

public class Sticker
{
    public string id { get; set; }
    public string name { get; set; }
    public Image image { get; set; }
    public string stickerType { get; set; }
    public Group1 group { get; set; }
    public Pickerposition pickerPosition { get; set; }
    public string teaseText { get; set; }
    public string unlockText { get; set; }
    public string bonusText { get; set; }
    public int points { get; set; }
    public string bonusStatus { get; set; }
}

public class Image
{
    public string prefix { get; set; }
    public int[] sizes { get; set; }
    public string name { get; set; }
}

public class Group1
{
    public string name { get; set; }
    public int index { get; set; }
}

public class Pickerposition
{
    public int page { get; set; }
    public int index { get; set; }
}

public class Notification
{
    public string type { get; set; }
    public Item3 item { get; set; }
}

public class Item3
{
    public int unreadCount { get; set; }
}
