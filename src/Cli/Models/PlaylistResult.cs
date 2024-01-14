namespace Cli.Models
{
    public class PlaylistResult
    {
        public Responsecontext responseContext { get; set; }
        public Contents contents { get; set; }
        public Header header { get; set; }
        public Metadata metadata { get; set; }
        public string trackingParams { get; set; }
        public Topbar topbar { get; set; }
        public Microformat microformat { get; set; }
        public Sidebar sidebar { get; set; }
    }

    public class Responsecontext
    {
        public Servicetrackingparam[] serviceTrackingParams { get; set; }
        public Mainappwebresponsecontext mainAppWebResponseContext { get; set; }
        public Webresponsecontextextensiondata webResponseContextExtensionData { get; set; }
    }

    public class Mainappwebresponsecontext
    {
        public bool loggedOut { get; set; }
        public string trackingParam { get; set; }
    }

    public class Webresponsecontextextensiondata
    {
        public Ytconfigdata ytConfigData { get; set; }
        public bool hasDecorated { get; set; }
    }

    public class Ytconfigdata
    {
        public string visitorData { get; set; }
        public int rootVisualElementType { get; set; }
    }

    public class Servicetrackingparam
    {
        public string service { get; set; }
        public Param[] _params { get; set; }
    }

    public class Param
    {
        public string key { get; set; }
        public string value { get; set; }
    }

    public class Contents
    {
        public Twocolumnbrowseresultsrenderer twoColumnBrowseResultsRenderer { get; set; }
    }

    public class Twocolumnbrowseresultsrenderer
    {
        public Tab[] tabs { get; set; }
    }

    public class Tab
    {
        public Tabrenderer tabRenderer { get; set; }
    }

    public class Tabrenderer
    {
        public bool selected { get; set; }
        public Content content { get; set; }
        public string trackingParams { get; set; }
    }

    public class Content
    {
        public Sectionlistrenderer sectionListRenderer { get; set; }
    }

    public class Sectionlistrenderer
    {
        public Content1[] contents { get; set; }
        public string trackingParams { get; set; }
        public string targetId { get; set; }
    }

    public class Content1
    {
        public Itemsectionrenderer itemSectionRenderer { get; set; }
        public Continuationitemrenderer continuationItemRenderer { get; set; }
    }

    public class Itemsectionrenderer
    {
        public Content2[] contents { get; set; }
        public string trackingParams { get; set; }
    }

    public class Content2
    {
        public Playlistvideolistrenderer playlistVideoListRenderer { get; set; }
    }

    public class Playlistvideolistrenderer
    {
        public Content3[] contents { get; set; }
        public string playlistId { get; set; }
        public bool isEditable { get; set; }
        public bool canReorder { get; set; }
        public string trackingParams { get; set; }
        public string targetId { get; set; }
    }

    public class Content3
    {
        public Playlistvideorenderer playlistVideoRenderer { get; set; }
    }

    public class Playlistvideorenderer
    {
        public string videoId { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Title title { get; set; }
        public Index index { get; set; }
        public Shortbylinetext shortBylineText { get; set; }
        public Lengthtext lengthText { get; set; }
        public Navigationendpoint1 navigationEndpoint { get; set; }
        public string lengthSeconds { get; set; }
        public string trackingParams { get; set; }
        public bool isPlayable { get; set; }
        public Menu menu { get; set; }
        public Thumbnailoverlay[] thumbnailOverlays { get; set; }
        public Videoinfo videoInfo { get; set; }
    }

    public class Thumbnail
    {
        public Thumbnail1[] thumbnails { get; set; }
    }

    public class Thumbnail1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Title
    {
        public Run[] runs { get; set; }
        public Accessibility accessibility { get; set; }
    }

    public class Accessibility
    {
        public Accessibilitydata accessibilityData { get; set; }
    }

    public class Accessibilitydata
    {
        public string label { get; set; }
    }

    public class Run
    {
        public string text { get; set; }
    }

    public class Index
    {
        public string simpleText { get; set; }
    }

    public class Shortbylinetext
    {
        public Run1[] runs { get; set; }
    }

    public class Run1
    {
        public string text { get; set; }
        public Navigationendpoint navigationEndpoint { get; set; }
    }

    public class Navigationendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata commandMetadata { get; set; }
        public Browseendpoint browseEndpoint { get; set; }
    }

    public class Commandmetadata
    {
        public Webcommandmetadata webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint
    {
        public string browseId { get; set; }
        public string canonicalBaseUrl { get; set; }
    }

    public class Lengthtext
    {
        public Accessibility1 accessibility { get; set; }
        public string simpleText { get; set; }
    }

    public class Accessibility1
    {
        public Accessibilitydata1 accessibilityData { get; set; }
    }

    public class Accessibilitydata1
    {
        public string label { get; set; }
    }

    public class Navigationendpoint1
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata1 commandMetadata { get; set; }
        public Watchendpoint watchEndpoint { get; set; }
    }

    public class Commandmetadata1
    {
        public Webcommandmetadata1 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata1
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Watchendpoint
    {
        public string videoId { get; set; }
        public string playlistId { get; set; }
        public int index { get; set; }
        public string _params { get; set; }
        public string playerParams { get; set; }
        public Loggingcontext loggingContext { get; set; }
        public Watchendpointsupportedonesieconfig watchEndpointSupportedOnesieConfig { get; set; }
    }

    public class Loggingcontext
    {
        public Vssloggingcontext vssLoggingContext { get; set; }
    }

    public class Vssloggingcontext
    {
        public string serializedContextData { get; set; }
    }

    public class Watchendpointsupportedonesieconfig
    {
        public Html5playbackonesieconfig html5PlaybackOnesieConfig { get; set; }
    }

    public class Html5playbackonesieconfig
    {
        public Commonconfig commonConfig { get; set; }
    }

    public class Commonconfig
    {
        public string url { get; set; }
    }

    public class Menu
    {
        public Menurenderer menuRenderer { get; set; }
    }

    public class Menurenderer
    {
        public Item[] items { get; set; }
        public string trackingParams { get; set; }
        public Accessibility2 accessibility { get; set; }
    }

    public class Accessibility2
    {
        public Accessibilitydata2 accessibilityData { get; set; }
    }

    public class Accessibilitydata2
    {
        public string label { get; set; }
    }

    public class Item
    {
        public Menuserviceitemrenderer menuServiceItemRenderer { get; set; }
    }

    public class Menuserviceitemrenderer
    {
        public Text text { get; set; }
        public Icon icon { get; set; }
        public Serviceendpoint serviceEndpoint { get; set; }
        public string trackingParams { get; set; }
        public bool hasSeparator { get; set; }
    }

    public class Text
    {
        public Run2[] runs { get; set; }
    }

    public class Run2
    {
        public string text { get; set; }
    }

    public class Icon
    {
        public string iconType { get; set; }
    }

    public class Serviceendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata2 commandMetadata { get; set; }
        public Signalserviceendpoint signalServiceEndpoint { get; set; }
        public Shareentityserviceendpoint shareEntityServiceEndpoint { get; set; }
    }

    public class Commandmetadata2
    {
        public Webcommandmetadata2 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata2
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Signalserviceendpoint
    {
        public string signal { get; set; }
        public Action[] actions { get; set; }
    }

    public class Action
    {
        public string clickTrackingParams { get; set; }
        public Addtoplaylistcommand addToPlaylistCommand { get; set; }
    }

    public class Addtoplaylistcommand
    {
        public bool openMiniplayer { get; set; }
        public string videoId { get; set; }
        public string listType { get; set; }
        public Oncreatelistcommand onCreateListCommand { get; set; }
        public string[] videoIds { get; set; }
    }

    public class Oncreatelistcommand
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata3 commandMetadata { get; set; }
        public Createplaylistserviceendpoint createPlaylistServiceEndpoint { get; set; }
    }

    public class Commandmetadata3
    {
        public Webcommandmetadata3 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata3
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Createplaylistserviceendpoint
    {
        public string[] videoIds { get; set; }
        public string _params { get; set; }
    }

    public class Shareentityserviceendpoint
    {
        public string serializedShareEntity { get; set; }
        public Command[] commands { get; set; }
    }

    public class Command
    {
        public string clickTrackingParams { get; set; }
        public Openpopupaction openPopupAction { get; set; }
    }

    public class Openpopupaction
    {
        public Popup popup { get; set; }
        public string popupType { get; set; }
        public bool beReused { get; set; }
    }

    public class Popup
    {
        public Unifiedsharepanelrenderer unifiedSharePanelRenderer { get; set; }
    }

    public class Unifiedsharepanelrenderer
    {
        public string trackingParams { get; set; }
        public bool showLoadingSpinner { get; set; }
    }

    public class Videoinfo
    {
        public Run3[] runs { get; set; }
    }

    public class Run3
    {
        public string text { get; set; }
    }

    public class Thumbnailoverlay
    {
        public Thumbnailoverlaytimestatusrenderer thumbnailOverlayTimeStatusRenderer { get; set; }
        public Thumbnailoverlaynowplayingrenderer thumbnailOverlayNowPlayingRenderer { get; set; }
    }

    public class Thumbnailoverlaytimestatusrenderer
    {
        public Text1 text { get; set; }
        public string style { get; set; }
    }

    public class Text1
    {
        public Accessibility3 accessibility { get; set; }
        public string simpleText { get; set; }
    }

    public class Accessibility3
    {
        public Accessibilitydata3 accessibilityData { get; set; }
    }

    public class Accessibilitydata3
    {
        public string label { get; set; }
    }

    public class Thumbnailoverlaynowplayingrenderer
    {
        public Text2 text { get; set; }
    }

    public class Text2
    {
        public Run4[] runs { get; set; }
    }

    public class Run4
    {
        public string text { get; set; }
    }

    public class Continuationitemrenderer
    {
        public string trigger { get; set; }
        public Continuationendpoint continuationEndpoint { get; set; }
    }

    public class Continuationendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata4 commandMetadata { get; set; }
        public Continuationcommand continuationCommand { get; set; }
    }

    public class Commandmetadata4
    {
        public Webcommandmetadata4 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata4
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Continuationcommand
    {
        public string token { get; set; }
        public string request { get; set; }
    }

    public class Header
    {
        public Playlistheaderrenderer playlistHeaderRenderer { get; set; }
    }

    public class Playlistheaderrenderer
    {
        public string playlistId { get; set; }
        public Title1 title { get; set; }
        public Numvideostext numVideosText { get; set; }
        public Descriptiontext descriptionText { get; set; }
        public Ownertext ownerText { get; set; }
        public Viewcounttext viewCountText { get; set; }
        public Sharedata shareData { get; set; }
        public bool isEditable { get; set; }
        public string privacy { get; set; }
        public Ownerendpoint ownerEndpoint { get; set; }
        public Editabledetails editableDetails { get; set; }
        public string trackingParams { get; set; }
        public Serviceendpoint2[] serviceEndpoints { get; set; }
        public Stat[] stats { get; set; }
        public Briefstat[] briefStats { get; set; }
        public Playlistheaderbanner playlistHeaderBanner { get; set; }
        public Savebutton saveButton { get; set; }
        public Sharebutton shareButton { get; set; }
        public Moreactionsmenu moreActionsMenu { get; set; }
        public Playbutton playButton { get; set; }
        public Shuffleplaybutton shufflePlayButton { get; set; }
        public Ondescriptiontap onDescriptionTap { get; set; }
        public Cinematiccontainer cinematicContainer { get; set; }
        public Byline[] byline { get; set; }
        public Descriptiontaptext descriptionTapText { get; set; }
    }

    public class Title1
    {
        public string simpleText { get; set; }
    }

    public class Numvideostext
    {
        public Run5[] runs { get; set; }
    }

    public class Run5
    {
        public string text { get; set; }
    }

    public class Descriptiontext
    {
    }

    public class Ownertext
    {
        public Run6[] runs { get; set; }
    }

    public class Run6
    {
        public string text { get; set; }
        public Navigationendpoint2 navigationEndpoint { get; set; }
    }

    public class Navigationendpoint2
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata5 commandMetadata { get; set; }
        public Browseendpoint1 browseEndpoint { get; set; }
    }

    public class Commandmetadata5
    {
        public Webcommandmetadata5 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata5
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint1
    {
        public string browseId { get; set; }
        public string canonicalBaseUrl { get; set; }
    }

    public class Viewcounttext
    {
        public string simpleText { get; set; }
    }

    public class Sharedata
    {
        public bool canShare { get; set; }
    }

    public class Ownerendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata6 commandMetadata { get; set; }
        public Browseendpoint2 browseEndpoint { get; set; }
    }

    public class Commandmetadata6
    {
        public Webcommandmetadata6 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata6
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint2
    {
        public string browseId { get; set; }
        public string canonicalBaseUrl { get; set; }
    }

    public class Editabledetails
    {
        public bool canDelete { get; set; }
    }

    public class Playlistheaderbanner
    {
        public Heroplaylistthumbnailrenderer heroPlaylistThumbnailRenderer { get; set; }
    }

    public class Heroplaylistthumbnailrenderer
    {
        public Thumbnail2 thumbnail { get; set; }
        public float maxRatio { get; set; }
        public string trackingParams { get; set; }
        public Ontap onTap { get; set; }
        public Thumbnailoverlays thumbnailOverlays { get; set; }
    }

    public class Thumbnail2
    {
        public Thumbnail3[] thumbnails { get; set; }
    }

    public class Thumbnail3
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Ontap
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata7 commandMetadata { get; set; }
        public Watchendpoint1 watchEndpoint { get; set; }
    }

    public class Commandmetadata7
    {
        public Webcommandmetadata7 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata7
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Watchendpoint1
    {
        public string videoId { get; set; }
        public string playlistId { get; set; }
        public string playerParams { get; set; }
        public Loggingcontext1 loggingContext { get; set; }
        public Watchendpointsupportedonesieconfig1 watchEndpointSupportedOnesieConfig { get; set; }
    }

    public class Loggingcontext1
    {
        public Vssloggingcontext1 vssLoggingContext { get; set; }
    }

    public class Vssloggingcontext1
    {
        public string serializedContextData { get; set; }
    }

    public class Watchendpointsupportedonesieconfig1
    {
        public Html5playbackonesieconfig1 html5PlaybackOnesieConfig { get; set; }
    }

    public class Html5playbackonesieconfig1
    {
        public Commonconfig1 commonConfig { get; set; }
    }

    public class Commonconfig1
    {
        public string url { get; set; }
    }

    public class Thumbnailoverlays
    {
        public Thumbnailoverlayhovertextrenderer thumbnailOverlayHoverTextRenderer { get; set; }
    }

    public class Thumbnailoverlayhovertextrenderer
    {
        public Text3 text { get; set; }
        public Icon1 icon { get; set; }
    }

    public class Text3
    {
        public string simpleText { get; set; }
    }

    public class Icon1
    {
        public string iconType { get; set; }
    }

    public class Savebutton
    {
        public Togglebuttonrenderer toggleButtonRenderer { get; set; }
    }

    public class Togglebuttonrenderer
    {
        public Style style { get; set; }
        public Size size { get; set; }
        public bool isToggled { get; set; }
        public bool isDisabled { get; set; }
        public Defaulticon defaultIcon { get; set; }
        public Toggledicon toggledIcon { get; set; }
        public string trackingParams { get; set; }
        public string defaultTooltip { get; set; }
        public string toggledTooltip { get; set; }
        public Toggledstyle toggledStyle { get; set; }
        public Defaultnavigationendpoint defaultNavigationEndpoint { get; set; }
        public Accessibilitydata4 accessibilityData { get; set; }
        public Toggledaccessibilitydata toggledAccessibilityData { get; set; }
    }

    public class Style
    {
        public string styleType { get; set; }
    }

    public class Size
    {
        public string sizeType { get; set; }
    }

    public class Defaulticon
    {
        public string iconType { get; set; }
    }

    public class Toggledicon
    {
        public string iconType { get; set; }
    }

    public class Toggledstyle
    {
        public string styleType { get; set; }
    }

    public class Defaultnavigationendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata8 commandMetadata { get; set; }
        public Modalendpoint modalEndpoint { get; set; }
    }

    public class Commandmetadata8
    {
        public Webcommandmetadata8 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata8
    {
        public bool ignoreNavigation { get; set; }
    }

    public class Modalendpoint
    {
        public Modal modal { get; set; }
    }

    public class Modal
    {
        public Modalwithtitleandbuttonrenderer modalWithTitleAndButtonRenderer { get; set; }
    }

    public class Modalwithtitleandbuttonrenderer
    {
        public Title2 title { get; set; }
        public Content4 content { get; set; }
        public Button button { get; set; }
    }

    public class Title2
    {
        public string simpleText { get; set; }
    }

    public class Content4
    {
        public string simpleText { get; set; }
    }

    public class Button
    {
        public Buttonrenderer buttonRenderer { get; set; }
    }

    public class Buttonrenderer
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text4 text { get; set; }
        public Navigationendpoint3 navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text4
    {
        public string simpleText { get; set; }
    }

    public class Navigationendpoint3
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata9 commandMetadata { get; set; }
        public Signinendpoint signInEndpoint { get; set; }
    }

    public class Commandmetadata9
    {
        public Webcommandmetadata9 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata9
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Signinendpoint
    {
        public Nextendpoint nextEndpoint { get; set; }
        public string idamTag { get; set; }
    }

    public class Nextendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata10 commandMetadata { get; set; }
        public Browseendpoint3 browseEndpoint { get; set; }
    }

    public class Commandmetadata10
    {
        public Webcommandmetadata10 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata10
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint3
    {
        public string browseId { get; set; }
    }

    public class Accessibilitydata4
    {
        public Accessibilitydata5 accessibilityData { get; set; }
    }

    public class Accessibilitydata5
    {
        public string label { get; set; }
    }

    public class Toggledaccessibilitydata
    {
        public Accessibilitydata6 accessibilityData { get; set; }
    }

    public class Accessibilitydata6
    {
        public string label { get; set; }
    }

    public class Sharebutton
    {
        public Buttonrenderer1 buttonRenderer { get; set; }
    }

    public class Buttonrenderer1
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Serviceendpoint1 serviceEndpoint { get; set; }
        public Icon2 icon { get; set; }
        public string tooltip { get; set; }
        public string trackingParams { get; set; }
        public Accessibilitydata7 accessibilityData { get; set; }
    }

    public class Serviceendpoint1
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata11 commandMetadata { get; set; }
        public Shareentityserviceendpoint1 shareEntityServiceEndpoint { get; set; }
    }

    public class Commandmetadata11
    {
        public Webcommandmetadata11 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata11
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Shareentityserviceendpoint1
    {
        public string serializedShareEntity { get; set; }
        public Command1[] commands { get; set; }
    }

    public class Command1
    {
        public string clickTrackingParams { get; set; }
        public Openpopupaction1 openPopupAction { get; set; }
    }

    public class Openpopupaction1
    {
        public Popup1 popup { get; set; }
        public string popupType { get; set; }
        public bool beReused { get; set; }
    }

    public class Popup1
    {
        public Unifiedsharepanelrenderer1 unifiedSharePanelRenderer { get; set; }
    }

    public class Unifiedsharepanelrenderer1
    {
        public string trackingParams { get; set; }
        public bool showLoadingSpinner { get; set; }
    }

    public class Icon2
    {
        public string iconType { get; set; }
    }

    public class Accessibilitydata7
    {
        public Accessibilitydata8 accessibilityData { get; set; }
    }

    public class Accessibilitydata8
    {
        public string label { get; set; }
    }

    public class Moreactionsmenu
    {
        public Menurenderer1 menuRenderer { get; set; }
    }

    public class Menurenderer1
    {
        public string trackingParams { get; set; }
        public Accessibility4 accessibility { get; set; }
    }

    public class Accessibility4
    {
        public Accessibilitydata9 accessibilityData { get; set; }
    }

    public class Accessibilitydata9
    {
        public string label { get; set; }
    }

    public class Playbutton
    {
        public Buttonrenderer2 buttonRenderer { get; set; }
    }

    public class Buttonrenderer2
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text5 text { get; set; }
        public Icon3 icon { get; set; }
        public Navigationendpoint4 navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text5
    {
        public string simpleText { get; set; }
    }

    public class Icon3
    {
        public string iconType { get; set; }
    }

    public class Navigationendpoint4
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata12 commandMetadata { get; set; }
        public Watchendpoint2 watchEndpoint { get; set; }
    }

    public class Commandmetadata12
    {
        public Webcommandmetadata12 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata12
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Watchendpoint2
    {
        public string videoId { get; set; }
        public string playlistId { get; set; }
        public string playerParams { get; set; }
        public Loggingcontext2 loggingContext { get; set; }
        public Watchendpointsupportedonesieconfig2 watchEndpointSupportedOnesieConfig { get; set; }
    }

    public class Loggingcontext2
    {
        public Vssloggingcontext2 vssLoggingContext { get; set; }
    }

    public class Vssloggingcontext2
    {
        public string serializedContextData { get; set; }
    }

    public class Watchendpointsupportedonesieconfig2
    {
        public Html5playbackonesieconfig2 html5PlaybackOnesieConfig { get; set; }
    }

    public class Html5playbackonesieconfig2
    {
        public Commonconfig2 commonConfig { get; set; }
    }

    public class Commonconfig2
    {
        public string url { get; set; }
    }

    public class Shuffleplaybutton
    {
        public Buttonrenderer3 buttonRenderer { get; set; }
    }

    public class Buttonrenderer3
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text6 text { get; set; }
        public Icon4 icon { get; set; }
        public Navigationendpoint5 navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text6
    {
        public string simpleText { get; set; }
    }

    public class Icon4
    {
        public string iconType { get; set; }
    }

    public class Navigationendpoint5
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata13 commandMetadata { get; set; }
        public Watchendpoint3 watchEndpoint { get; set; }
    }

    public class Commandmetadata13
    {
        public Webcommandmetadata13 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata13
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Watchendpoint3
    {
        public string videoId { get; set; }
        public string playlistId { get; set; }
        public string _params { get; set; }
        public string playerParams { get; set; }
        public Loggingcontext3 loggingContext { get; set; }
        public Watchendpointsupportedonesieconfig3 watchEndpointSupportedOnesieConfig { get; set; }
    }

    public class Loggingcontext3
    {
        public Vssloggingcontext3 vssLoggingContext { get; set; }
    }

    public class Vssloggingcontext3
    {
        public string serializedContextData { get; set; }
    }

    public class Watchendpointsupportedonesieconfig3
    {
        public Html5playbackonesieconfig3 html5PlaybackOnesieConfig { get; set; }
    }

    public class Html5playbackonesieconfig3
    {
        public Commonconfig3 commonConfig { get; set; }
    }

    public class Commonconfig3
    {
        public string url { get; set; }
    }

    public class Ondescriptiontap
    {
        public string clickTrackingParams { get; set; }
        public Openpopupaction2 openPopupAction { get; set; }
    }

    public class Openpopupaction2
    {
        public Popup2 popup { get; set; }
        public string popupType { get; set; }
    }

    public class Popup2
    {
        public Fancydismissibledialogrenderer fancyDismissibleDialogRenderer { get; set; }
    }

    public class Fancydismissibledialogrenderer
    {
        public Dialogmessage dialogMessage { get; set; }
        public Title3 title { get; set; }
        public Confirmlabel confirmLabel { get; set; }
        public string trackingParams { get; set; }
    }

    public class Dialogmessage
    {
    }

    public class Title3
    {
        public Run7[] runs { get; set; }
    }

    public class Run7
    {
        public string text { get; set; }
    }

    public class Confirmlabel
    {
        public Run8[] runs { get; set; }
    }

    public class Run8
    {
        public string text { get; set; }
    }

    public class Cinematiccontainer
    {
        public Cinematiccontainerrenderer cinematicContainerRenderer { get; set; }
    }

    public class Cinematiccontainerrenderer
    {
        public Backgroundimageconfig backgroundImageConfig { get; set; }
        public Gradientcolorconfig[] gradientColorConfig { get; set; }
        public Config config { get; set; }
    }

    public class Backgroundimageconfig
    {
        public Thumbnail4 thumbnail { get; set; }
    }

    public class Thumbnail4
    {
        public Thumbnail5[] thumbnails { get; set; }
    }

    public class Thumbnail5
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Config
    {
        public long lightThemeBackgroundColor { get; set; }
        public long darkThemeBackgroundColor { get; set; }
        public int colorSourceSizeMultiplier { get; set; }
        public bool applyClientImageBlur { get; set; }
    }

    public class Gradientcolorconfig
    {
        public long lightThemeColor { get; set; }
        public long darkThemeColor { get; set; }
        public float startLocation { get; set; }
    }

    public class Descriptiontaptext
    {
        public Run9[] runs { get; set; }
    }

    public class Run9
    {
        public string text { get; set; }
    }

    public class Serviceendpoint2
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata14 commandMetadata { get; set; }
        public Playlisteditendpoint playlistEditEndpoint { get; set; }
    }

    public class Commandmetadata14
    {
        public Webcommandmetadata14 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata14
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Playlisteditendpoint
    {
        public Action1[] actions { get; set; }
    }

    public class Action1
    {
        public string action { get; set; }
        public string sourcePlaylistId { get; set; }
    }

    public class Stat
    {
        public Run10[] runs { get; set; }
        public string simpleText { get; set; }
    }

    public class Run10
    {
        public string text { get; set; }
    }

    public class Briefstat
    {
        public Run11[] runs { get; set; }
    }

    public class Run11
    {
        public string text { get; set; }
    }

    public class Byline
    {
        public Playlistbylinerenderer playlistBylineRenderer { get; set; }
    }

    public class Playlistbylinerenderer
    {
        public Text7 text { get; set; }
    }

    public class Text7
    {
        public Run12[] runs { get; set; }
        public string simpleText { get; set; }
    }

    public class Run12
    {
        public string text { get; set; }
    }

    public class Metadata
    {
        public Playlistmetadatarenderer playlistMetadataRenderer { get; set; }
    }

    public class Playlistmetadatarenderer
    {
        public string title { get; set; }
        public string androidAppindexingLink { get; set; }
        public string iosAppindexingLink { get; set; }
    }

    public class Topbar
    {
        public Desktoptopbarrenderer desktopTopbarRenderer { get; set; }
    }

    public class Desktoptopbarrenderer
    {
        public Logo logo { get; set; }
        public Searchbox searchbox { get; set; }
        public string trackingParams { get; set; }
        public string countryCode { get; set; }
        public Topbarbutton[] topbarButtons { get; set; }
        public Hotkeydialog hotkeyDialog { get; set; }
        public Backbutton backButton { get; set; }
        public Forwardbutton forwardButton { get; set; }
        public A11yskipnavigationbutton a11ySkipNavigationButton { get; set; }
        public Voicesearchbutton voiceSearchButton { get; set; }
    }

    public class Logo
    {
        public Topbarlogorenderer topbarLogoRenderer { get; set; }
    }

    public class Topbarlogorenderer
    {
        public Iconimage iconImage { get; set; }
        public Tooltiptext tooltipText { get; set; }
        public Endpoint endpoint { get; set; }
        public string trackingParams { get; set; }
        public string overrideEntityKey { get; set; }
    }

    public class Iconimage
    {
        public string iconType { get; set; }
    }

    public class Tooltiptext
    {
        public Run13[] runs { get; set; }
    }

    public class Run13
    {
        public string text { get; set; }
    }

    public class Endpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata15 commandMetadata { get; set; }
        public Browseendpoint4 browseEndpoint { get; set; }
    }

    public class Commandmetadata15
    {
        public Webcommandmetadata15 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata15
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint4
    {
        public string browseId { get; set; }
    }

    public class Searchbox
    {
        public Fusionsearchboxrenderer fusionSearchboxRenderer { get; set; }
    }

    public class Fusionsearchboxrenderer
    {
        public Icon5 icon { get; set; }
        public Placeholdertext placeholderText { get; set; }
        public Config1 config { get; set; }
        public string trackingParams { get; set; }
        public Searchendpoint searchEndpoint { get; set; }
        public Clearbutton clearButton { get; set; }
    }

    public class Icon5
    {
        public string iconType { get; set; }
    }

    public class Placeholdertext
    {
        public Run14[] runs { get; set; }
    }

    public class Run14
    {
        public string text { get; set; }
    }

    public class Config1
    {
        public Websearchboxconfig webSearchboxConfig { get; set; }
    }

    public class Websearchboxconfig
    {
        public string requestLanguage { get; set; }
        public string requestDomain { get; set; }
        public bool hasOnscreenKeyboard { get; set; }
        public bool focusSearchbox { get; set; }
    }

    public class Searchendpoint
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata16 commandMetadata { get; set; }
        public Searchendpoint1 searchEndpoint { get; set; }
    }

    public class Commandmetadata16
    {
        public Webcommandmetadata16 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata16
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Searchendpoint1
    {
        public string query { get; set; }
    }

    public class Clearbutton
    {
        public Buttonrenderer4 buttonRenderer { get; set; }
    }

    public class Buttonrenderer4
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Icon6 icon { get; set; }
        public string trackingParams { get; set; }
        public Accessibilitydata10 accessibilityData { get; set; }
    }

    public class Icon6
    {
        public string iconType { get; set; }
    }

    public class Accessibilitydata10
    {
        public Accessibilitydata11 accessibilityData { get; set; }
    }

    public class Accessibilitydata11
    {
        public string label { get; set; }
    }

    public class Hotkeydialog
    {
        public Hotkeydialogrenderer hotkeyDialogRenderer { get; set; }
    }

    public class Hotkeydialogrenderer
    {
        public Title4 title { get; set; }
        public Section[] sections { get; set; }
        public Dismissbutton dismissButton { get; set; }
        public string trackingParams { get; set; }
    }

    public class Title4
    {
        public Run15[] runs { get; set; }
    }

    public class Run15
    {
        public string text { get; set; }
    }

    public class Dismissbutton
    {
        public Buttonrenderer5 buttonRenderer { get; set; }
    }

    public class Buttonrenderer5
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text8 text { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text8
    {
        public Run16[] runs { get; set; }
    }

    public class Run16
    {
        public string text { get; set; }
    }

    public class Section
    {
        public Hotkeydialogsectionrenderer hotkeyDialogSectionRenderer { get; set; }
    }

    public class Hotkeydialogsectionrenderer
    {
        public Title5 title { get; set; }
        public Option[] options { get; set; }
    }

    public class Title5
    {
        public Run17[] runs { get; set; }
    }

    public class Run17
    {
        public string text { get; set; }
    }

    public class Option
    {
        public Hotkeydialogsectionoptionrenderer hotkeyDialogSectionOptionRenderer { get; set; }
    }

    public class Hotkeydialogsectionoptionrenderer
    {
        public Label label { get; set; }
        public string hotkey { get; set; }
        public Hotkeyaccessibilitylabel hotkeyAccessibilityLabel { get; set; }
    }

    public class Label
    {
        public Run18[] runs { get; set; }
    }

    public class Run18
    {
        public string text { get; set; }
    }

    public class Hotkeyaccessibilitylabel
    {
        public Accessibilitydata12 accessibilityData { get; set; }
    }

    public class Accessibilitydata12
    {
        public string label { get; set; }
    }

    public class Backbutton
    {
        public Buttonrenderer6 buttonRenderer { get; set; }
    }

    public class Buttonrenderer6
    {
        public string trackingParams { get; set; }
        public Command2 command { get; set; }
    }

    public class Command2
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata17 commandMetadata { get; set; }
        public Signalserviceendpoint1 signalServiceEndpoint { get; set; }
    }

    public class Commandmetadata17
    {
        public Webcommandmetadata17 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata17
    {
        public bool sendPost { get; set; }
    }

    public class Signalserviceendpoint1
    {
        public string signal { get; set; }
        public Action2[] actions { get; set; }
    }

    public class Action2
    {
        public string clickTrackingParams { get; set; }
        public Signalaction signalAction { get; set; }
    }

    public class Signalaction
    {
        public string signal { get; set; }
    }

    public class Forwardbutton
    {
        public Buttonrenderer7 buttonRenderer { get; set; }
    }

    public class Buttonrenderer7
    {
        public string trackingParams { get; set; }
        public Command3 command { get; set; }
    }

    public class Command3
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata18 commandMetadata { get; set; }
        public Signalserviceendpoint2 signalServiceEndpoint { get; set; }
    }

    public class Commandmetadata18
    {
        public Webcommandmetadata18 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata18
    {
        public bool sendPost { get; set; }
    }

    public class Signalserviceendpoint2
    {
        public string signal { get; set; }
        public Action3[] actions { get; set; }
    }

    public class Action3
    {
        public string clickTrackingParams { get; set; }
        public Signalaction1 signalAction { get; set; }
    }

    public class Signalaction1
    {
        public string signal { get; set; }
    }

    public class A11yskipnavigationbutton
    {
        public Buttonrenderer8 buttonRenderer { get; set; }
    }

    public class Buttonrenderer8
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text9 text { get; set; }
        public string trackingParams { get; set; }
        public Command4 command { get; set; }
    }

    public class Text9
    {
        public Run19[] runs { get; set; }
    }

    public class Run19
    {
        public string text { get; set; }
    }

    public class Command4
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata19 commandMetadata { get; set; }
        public Signalserviceendpoint3 signalServiceEndpoint { get; set; }
    }

    public class Commandmetadata19
    {
        public Webcommandmetadata19 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata19
    {
        public bool sendPost { get; set; }
    }

    public class Signalserviceendpoint3
    {
        public string signal { get; set; }
        public Action4[] actions { get; set; }
    }

    public class Action4
    {
        public string clickTrackingParams { get; set; }
        public Signalaction2 signalAction { get; set; }
    }

    public class Signalaction2
    {
        public string signal { get; set; }
    }

    public class Voicesearchbutton
    {
        public Buttonrenderer9 buttonRenderer { get; set; }
    }

    public class Buttonrenderer9
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Serviceendpoint3 serviceEndpoint { get; set; }
        public Icon8 icon { get; set; }
        public string tooltip { get; set; }
        public string trackingParams { get; set; }
        public Accessibilitydata15 accessibilityData { get; set; }
    }

    public class Serviceendpoint3
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata20 commandMetadata { get; set; }
        public Signalserviceendpoint4 signalServiceEndpoint { get; set; }
    }

    public class Commandmetadata20
    {
        public Webcommandmetadata20 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata20
    {
        public bool sendPost { get; set; }
    }

    public class Signalserviceendpoint4
    {
        public string signal { get; set; }
        public Action5[] actions { get; set; }
    }

    public class Action5
    {
        public string clickTrackingParams { get; set; }
        public Openpopupaction3 openPopupAction { get; set; }
    }

    public class Openpopupaction3
    {
        public Popup3 popup { get; set; }
        public string popupType { get; set; }
    }

    public class Popup3
    {
        public Voicesearchdialogrenderer voiceSearchDialogRenderer { get; set; }
    }

    public class Voicesearchdialogrenderer
    {
        public Placeholderheader placeholderHeader { get; set; }
        public Promptheader promptHeader { get; set; }
        public Examplequery1 exampleQuery1 { get; set; }
        public Examplequery2 exampleQuery2 { get; set; }
        public Promptmicrophonelabel promptMicrophoneLabel { get; set; }
        public Loadingheader loadingHeader { get; set; }
        public Connectionerrorheader connectionErrorHeader { get; set; }
        public Connectionerrormicrophonelabel connectionErrorMicrophoneLabel { get; set; }
        public Permissionsheader permissionsHeader { get; set; }
        public Permissionssubtext permissionsSubtext { get; set; }
        public Disabledheader disabledHeader { get; set; }
        public Disabledsubtext disabledSubtext { get; set; }
        public Microphonebuttonarialabel microphoneButtonAriaLabel { get; set; }
        public Exitbutton exitButton { get; set; }
        public string trackingParams { get; set; }
        public Microphoneoffpromptheader microphoneOffPromptHeader { get; set; }
    }

    public class Placeholderheader
    {
        public Run20[] runs { get; set; }
    }

    public class Run20
    {
        public string text { get; set; }
    }

    public class Promptheader
    {
        public Run21[] runs { get; set; }
    }

    public class Run21
    {
        public string text { get; set; }
    }

    public class Examplequery1
    {
        public Run22[] runs { get; set; }
    }

    public class Run22
    {
        public string text { get; set; }
    }

    public class Examplequery2
    {
        public Run23[] runs { get; set; }
    }

    public class Run23
    {
        public string text { get; set; }
    }

    public class Promptmicrophonelabel
    {
        public Run24[] runs { get; set; }
    }

    public class Run24
    {
        public string text { get; set; }
    }

    public class Loadingheader
    {
        public Run25[] runs { get; set; }
    }

    public class Run25
    {
        public string text { get; set; }
    }

    public class Connectionerrorheader
    {
        public Run26[] runs { get; set; }
    }

    public class Run26
    {
        public string text { get; set; }
    }

    public class Connectionerrormicrophonelabel
    {
        public Run27[] runs { get; set; }
    }

    public class Run27
    {
        public string text { get; set; }
    }

    public class Permissionsheader
    {
        public Run28[] runs { get; set; }
    }

    public class Run28
    {
        public string text { get; set; }
    }

    public class Permissionssubtext
    {
        public Run29[] runs { get; set; }
    }

    public class Run29
    {
        public string text { get; set; }
    }

    public class Disabledheader
    {
        public Run30[] runs { get; set; }
    }

    public class Run30
    {
        public string text { get; set; }
    }

    public class Disabledsubtext
    {
        public Run31[] runs { get; set; }
    }

    public class Run31
    {
        public string text { get; set; }
    }

    public class Microphonebuttonarialabel
    {
        public Run32[] runs { get; set; }
    }

    public class Run32
    {
        public string text { get; set; }
    }

    public class Exitbutton
    {
        public Buttonrenderer10 buttonRenderer { get; set; }
    }

    public class Buttonrenderer10
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Icon7 icon { get; set; }
        public string trackingParams { get; set; }
        public Accessibilitydata13 accessibilityData { get; set; }
    }

    public class Icon7
    {
        public string iconType { get; set; }
    }

    public class Accessibilitydata13
    {
        public Accessibilitydata14 accessibilityData { get; set; }
    }

    public class Accessibilitydata14
    {
        public string label { get; set; }
    }

    public class Microphoneoffpromptheader
    {
        public Run33[] runs { get; set; }
    }

    public class Run33
    {
        public string text { get; set; }
    }

    public class Icon8
    {
        public string iconType { get; set; }
    }

    public class Accessibilitydata15
    {
        public Accessibilitydata16 accessibilityData { get; set; }
    }

    public class Accessibilitydata16
    {
        public string label { get; set; }
    }

    public class Topbarbutton
    {
        public Topbarmenubuttonrenderer topbarMenuButtonRenderer { get; set; }
        public Buttonrenderer11 buttonRenderer { get; set; }
    }

    public class Topbarmenubuttonrenderer
    {
        public Icon9 icon { get; set; }
        public Menurequest menuRequest { get; set; }
        public string trackingParams { get; set; }
        public Accessibility5 accessibility { get; set; }
        public string tooltip { get; set; }
        public string style { get; set; }
    }

    public class Icon9
    {
        public string iconType { get; set; }
    }

    public class Menurequest
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata21 commandMetadata { get; set; }
        public Signalserviceendpoint5 signalServiceEndpoint { get; set; }
    }

    public class Commandmetadata21
    {
        public Webcommandmetadata21 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata21
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Signalserviceendpoint5
    {
        public string signal { get; set; }
        public Action6[] actions { get; set; }
    }

    public class Action6
    {
        public string clickTrackingParams { get; set; }
        public Openpopupaction4 openPopupAction { get; set; }
    }

    public class Openpopupaction4
    {
        public Popup4 popup { get; set; }
        public string popupType { get; set; }
        public bool beReused { get; set; }
    }

    public class Popup4
    {
        public Multipagemenurenderer multiPageMenuRenderer { get; set; }
    }

    public class Multipagemenurenderer
    {
        public string trackingParams { get; set; }
        public string style { get; set; }
        public bool showLoadingSpinner { get; set; }
    }

    public class Accessibility5
    {
        public Accessibilitydata17 accessibilityData { get; set; }
    }

    public class Accessibilitydata17
    {
        public string label { get; set; }
    }

    public class Buttonrenderer11
    {
        public string style { get; set; }
        public string size { get; set; }
        public Text10 text { get; set; }
        public Icon10 icon { get; set; }
        public Navigationendpoint6 navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
        public string targetId { get; set; }
    }

    public class Text10
    {
        public Run34[] runs { get; set; }
    }

    public class Run34
    {
        public string text { get; set; }
    }

    public class Icon10
    {
        public string iconType { get; set; }
    }

    public class Navigationendpoint6
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata22 commandMetadata { get; set; }
        public Signinendpoint1 signInEndpoint { get; set; }
    }

    public class Commandmetadata22
    {
        public Webcommandmetadata22 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata22
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Signinendpoint1
    {
        public string idamTag { get; set; }
    }

    public class Microformat
    {
        public Microformatdatarenderer microformatDataRenderer { get; set; }
    }

    public class Microformatdatarenderer
    {
        public string urlCanonical { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Thumbnail6 thumbnail { get; set; }
        public string siteName { get; set; }
        public string appName { get; set; }
        public string androidPackage { get; set; }
        public string iosAppStoreId { get; set; }
        public string iosAppArguments { get; set; }
        public string ogType { get; set; }
        public string urlApplinksWeb { get; set; }
        public string urlApplinksIos { get; set; }
        public string urlApplinksAndroid { get; set; }
        public string urlTwitterIos { get; set; }
        public string urlTwitterAndroid { get; set; }
        public string twitterCardType { get; set; }
        public string twitterSiteHandle { get; set; }
        public string schemaDotOrgType { get; set; }
        public bool noindex { get; set; }
        public bool unlisted { get; set; }
        public Linkalternate[] linkAlternates { get; set; }
    }

    public class Thumbnail6
    {
        public Thumbnail7[] thumbnails { get; set; }
    }

    public class Thumbnail7
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Linkalternate
    {
        public string hrefUrl { get; set; }
    }

    public class Sidebar
    {
        public Playlistsidebarrenderer playlistSidebarRenderer { get; set; }
    }

    public class Playlistsidebarrenderer
    {
        public Item1[] items { get; set; }
        public string trackingParams { get; set; }
    }

    public class Item1
    {
        public Playlistsidebarprimaryinforenderer playlistSidebarPrimaryInfoRenderer { get; set; }
        public Playlistsidebarsecondaryinforenderer playlistSidebarSecondaryInfoRenderer { get; set; }
    }

    public class Playlistsidebarprimaryinforenderer
    {
        public Thumbnailrenderer thumbnailRenderer { get; set; }
        public Title6 title { get; set; }
        public Stat1[] stats { get; set; }
        public Menu1 menu { get; set; }
        public Thumbnailoverlay1[] thumbnailOverlays { get; set; }
        public Navigationendpoint12 navigationEndpoint { get; set; }
        public Description description { get; set; }
        public Showmoretext showMoreText { get; set; }
    }

    public class Thumbnailrenderer
    {
        public Playlistvideothumbnailrenderer playlistVideoThumbnailRenderer { get; set; }
    }

    public class Playlistvideothumbnailrenderer
    {
        public Thumbnail8 thumbnail { get; set; }
        public string trackingParams { get; set; }
    }

    public class Thumbnail8
    {
        public Thumbnail9[] thumbnails { get; set; }
    }

    public class Thumbnail9
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Title6
    {
        public Run35[] runs { get; set; }
    }

    public class Run35
    {
        public string text { get; set; }
        public Navigationendpoint7 navigationEndpoint { get; set; }
    }

    public class Navigationendpoint7
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata23 commandMetadata { get; set; }
        public Watchendpoint4 watchEndpoint { get; set; }
    }

    public class Commandmetadata23
    {
        public Webcommandmetadata23 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata23
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Watchendpoint4
    {
        public string videoId { get; set; }
        public string playlistId { get; set; }
        public string playerParams { get; set; }
        public Loggingcontext4 loggingContext { get; set; }
        public Watchendpointsupportedonesieconfig4 watchEndpointSupportedOnesieConfig { get; set; }
    }

    public class Loggingcontext4
    {
        public Vssloggingcontext4 vssLoggingContext { get; set; }
    }

    public class Vssloggingcontext4
    {
        public string serializedContextData { get; set; }
    }

    public class Watchendpointsupportedonesieconfig4
    {
        public Html5playbackonesieconfig4 html5PlaybackOnesieConfig { get; set; }
    }

    public class Html5playbackonesieconfig4
    {
        public Commonconfig4 commonConfig { get; set; }
    }

    public class Commonconfig4
    {
        public string url { get; set; }
    }

    public class Menu1
    {
        public Menurenderer2 menuRenderer { get; set; }
    }

    public class Menurenderer2
    {
        public Item2[] items { get; set; }
        public string trackingParams { get; set; }
        public Toplevelbutton[] topLevelButtons { get; set; }
        public Accessibility6 accessibility { get; set; }
    }

    public class Accessibility6
    {
        public Accessibilitydata18 accessibilityData { get; set; }
    }

    public class Accessibilitydata18
    {
        public string label { get; set; }
    }

    public class Item2
    {
        public Menunavigationitemrenderer menuNavigationItemRenderer { get; set; }
    }

    public class Menunavigationitemrenderer
    {
        public Text11 text { get; set; }
        public Icon11 icon { get; set; }
        public Navigationendpoint8 navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text11
    {
        public string simpleText { get; set; }
    }

    public class Icon11
    {
        public string iconType { get; set; }
    }

    public class Navigationendpoint8
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata24 commandMetadata { get; set; }
        public Modalendpoint1 modalEndpoint { get; set; }
    }

    public class Commandmetadata24
    {
        public Webcommandmetadata24 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata24
    {
        public bool ignoreNavigation { get; set; }
    }

    public class Modalendpoint1
    {
        public Modal1 modal { get; set; }
    }

    public class Modal1
    {
        public Modalwithtitleandbuttonrenderer1 modalWithTitleAndButtonRenderer { get; set; }
    }

    public class Modalwithtitleandbuttonrenderer1
    {
        public Title7 title { get; set; }
        public Content5 content { get; set; }
        public Button1 button { get; set; }
    }

    public class Title7
    {
        public string simpleText { get; set; }
    }

    public class Content5
    {
        public string simpleText { get; set; }
    }

    public class Button1
    {
        public Buttonrenderer12 buttonRenderer { get; set; }
    }

    public class Buttonrenderer12
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text12 text { get; set; }
        public Navigationendpoint9 navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text12
    {
        public Run36[] runs { get; set; }
    }

    public class Run36
    {
        public string text { get; set; }
    }

    public class Navigationendpoint9
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata25 commandMetadata { get; set; }
        public Signinendpoint2 signInEndpoint { get; set; }
    }

    public class Commandmetadata25
    {
        public Webcommandmetadata25 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata25
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Signinendpoint2
    {
        public Nextendpoint1 nextEndpoint { get; set; }
    }

    public class Nextendpoint1
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata26 commandMetadata { get; set; }
        public Browseendpoint5 browseEndpoint { get; set; }
    }

    public class Commandmetadata26
    {
        public Webcommandmetadata26 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata26
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint5
    {
        public string browseId { get; set; }
    }

    public class Toplevelbutton
    {
        public Togglebuttonrenderer1 toggleButtonRenderer { get; set; }
        public Buttonrenderer14 buttonRenderer { get; set; }
    }

    public class Togglebuttonrenderer1
    {
        public Style1 style { get; set; }
        public Size1 size { get; set; }
        public bool isToggled { get; set; }
        public bool isDisabled { get; set; }
        public Defaulticon1 defaultIcon { get; set; }
        public Toggledicon1 toggledIcon { get; set; }
        public string trackingParams { get; set; }
        public string defaultTooltip { get; set; }
        public string toggledTooltip { get; set; }
        public Defaultnavigationendpoint1 defaultNavigationEndpoint { get; set; }
        public Accessibilitydata19 accessibilityData { get; set; }
        public Toggledaccessibilitydata1 toggledAccessibilityData { get; set; }
    }

    public class Style1
    {
        public string styleType { get; set; }
    }

    public class Size1
    {
        public string sizeType { get; set; }
    }

    public class Defaulticon1
    {
        public string iconType { get; set; }
    }

    public class Toggledicon1
    {
        public string iconType { get; set; }
    }

    public class Defaultnavigationendpoint1
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata27 commandMetadata { get; set; }
        public Modalendpoint2 modalEndpoint { get; set; }
    }

    public class Commandmetadata27
    {
        public Webcommandmetadata27 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata27
    {
        public bool ignoreNavigation { get; set; }
    }

    public class Modalendpoint2
    {
        public Modal2 modal { get; set; }
    }

    public class Modal2
    {
        public Modalwithtitleandbuttonrenderer2 modalWithTitleAndButtonRenderer { get; set; }
    }

    public class Modalwithtitleandbuttonrenderer2
    {
        public Title8 title { get; set; }
        public Content6 content { get; set; }
        public Button2 button { get; set; }
    }

    public class Title8
    {
        public string simpleText { get; set; }
    }

    public class Content6
    {
        public string simpleText { get; set; }
    }

    public class Button2
    {
        public Buttonrenderer13 buttonRenderer { get; set; }
    }

    public class Buttonrenderer13
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text13 text { get; set; }
        public Navigationendpoint10 navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text13
    {
        public string simpleText { get; set; }
    }

    public class Navigationendpoint10
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata28 commandMetadata { get; set; }
        public Signinendpoint3 signInEndpoint { get; set; }
    }

    public class Commandmetadata28
    {
        public Webcommandmetadata28 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata28
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Signinendpoint3
    {
        public Nextendpoint2 nextEndpoint { get; set; }
        public string idamTag { get; set; }
    }

    public class Nextendpoint2
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata29 commandMetadata { get; set; }
        public Browseendpoint6 browseEndpoint { get; set; }
    }

    public class Commandmetadata29
    {
        public Webcommandmetadata29 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata29
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint6
    {
        public string browseId { get; set; }
    }

    public class Accessibilitydata19
    {
        public Accessibilitydata20 accessibilityData { get; set; }
    }

    public class Accessibilitydata20
    {
        public string label { get; set; }
    }

    public class Toggledaccessibilitydata1
    {
        public Accessibilitydata21 accessibilityData { get; set; }
    }

    public class Accessibilitydata21
    {
        public string label { get; set; }
    }

    public class Buttonrenderer14
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Icon12 icon { get; set; }
        public Navigationendpoint11 navigationEndpoint { get; set; }
        public Accessibility7 accessibility { get; set; }
        public string tooltip { get; set; }
        public string trackingParams { get; set; }
        public Serviceendpoint4 serviceEndpoint { get; set; }
    }

    public class Icon12
    {
        public string iconType { get; set; }
    }

    public class Navigationendpoint11
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata30 commandMetadata { get; set; }
        public Watchendpoint5 watchEndpoint { get; set; }
    }

    public class Commandmetadata30
    {
        public Webcommandmetadata30 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata30
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Watchendpoint5
    {
        public string videoId { get; set; }
        public string playlistId { get; set; }
        public string _params { get; set; }
        public string playerParams { get; set; }
        public Loggingcontext5 loggingContext { get; set; }
        public Watchendpointsupportedonesieconfig5 watchEndpointSupportedOnesieConfig { get; set; }
    }

    public class Loggingcontext5
    {
        public Vssloggingcontext5 vssLoggingContext { get; set; }
    }

    public class Vssloggingcontext5
    {
        public string serializedContextData { get; set; }
    }

    public class Watchendpointsupportedonesieconfig5
    {
        public Html5playbackonesieconfig5 html5PlaybackOnesieConfig { get; set; }
    }

    public class Html5playbackonesieconfig5
    {
        public Commonconfig5 commonConfig { get; set; }
    }

    public class Commonconfig5
    {
        public string url { get; set; }
    }

    public class Accessibility7
    {
        public string label { get; set; }
    }

    public class Serviceendpoint4
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata31 commandMetadata { get; set; }
        public Shareentityserviceendpoint2 shareEntityServiceEndpoint { get; set; }
    }

    public class Commandmetadata31
    {
        public Webcommandmetadata31 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata31
    {
        public bool sendPost { get; set; }
        public string apiUrl { get; set; }
    }

    public class Shareentityserviceendpoint2
    {
        public string serializedShareEntity { get; set; }
        public Command5[] commands { get; set; }
    }

    public class Command5
    {
        public string clickTrackingParams { get; set; }
        public Openpopupaction5 openPopupAction { get; set; }
    }

    public class Openpopupaction5
    {
        public Popup5 popup { get; set; }
        public string popupType { get; set; }
        public bool beReused { get; set; }
    }

    public class Popup5
    {
        public Unifiedsharepanelrenderer2 unifiedSharePanelRenderer { get; set; }
    }

    public class Unifiedsharepanelrenderer2
    {
        public string trackingParams { get; set; }
        public bool showLoadingSpinner { get; set; }
    }

    public class Navigationendpoint12
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata32 commandMetadata { get; set; }
        public Watchendpoint6 watchEndpoint { get; set; }
    }

    public class Commandmetadata32
    {
        public Webcommandmetadata32 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata32
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Watchendpoint6
    {
        public string videoId { get; set; }
        public string playlistId { get; set; }
        public string playerParams { get; set; }
        public Loggingcontext6 loggingContext { get; set; }
        public Watchendpointsupportedonesieconfig6 watchEndpointSupportedOnesieConfig { get; set; }
    }

    public class Loggingcontext6
    {
        public Vssloggingcontext6 vssLoggingContext { get; set; }
    }

    public class Vssloggingcontext6
    {
        public string serializedContextData { get; set; }
    }

    public class Watchendpointsupportedonesieconfig6
    {
        public Html5playbackonesieconfig6 html5PlaybackOnesieConfig { get; set; }
    }

    public class Html5playbackonesieconfig6
    {
        public Commonconfig6 commonConfig { get; set; }
    }

    public class Commonconfig6
    {
        public string url { get; set; }
    }

    public class Description
    {
    }

    public class Showmoretext
    {
        public Run37[] runs { get; set; }
    }

    public class Run37
    {
        public string text { get; set; }
    }

    public class Stat1
    {
        public Run38[] runs { get; set; }
        public string simpleText { get; set; }
    }

    public class Run38
    {
        public string text { get; set; }
    }

    public class Thumbnailoverlay1
    {
        public Thumbnailoverlaysidepanelrenderer thumbnailOverlaySidePanelRenderer { get; set; }
    }

    public class Thumbnailoverlaysidepanelrenderer
    {
        public Text14 text { get; set; }
        public Icon13 icon { get; set; }
    }

    public class Text14
    {
        public string simpleText { get; set; }
    }

    public class Icon13
    {
        public string iconType { get; set; }
    }

    public class Playlistsidebarsecondaryinforenderer
    {
        public Videoowner videoOwner { get; set; }
        public Button3 button { get; set; }
    }

    public class Videoowner
    {
        public Videoownerrenderer videoOwnerRenderer { get; set; }
    }

    public class Videoownerrenderer
    {
        public Thumbnail10 thumbnail { get; set; }
        public Title9 title { get; set; }
        public Navigationendpoint14 navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
    }

    public class Thumbnail10
    {
        public Thumbnail11[] thumbnails { get; set; }
    }

    public class Thumbnail11
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Title9
    {
        public Run39[] runs { get; set; }
    }

    public class Run39
    {
        public string text { get; set; }
        public Navigationendpoint13 navigationEndpoint { get; set; }
    }

    public class Navigationendpoint13
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata33 commandMetadata { get; set; }
        public Browseendpoint7 browseEndpoint { get; set; }
    }

    public class Commandmetadata33
    {
        public Webcommandmetadata33 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata33
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint7
    {
        public string browseId { get; set; }
        public string canonicalBaseUrl { get; set; }
    }

    public class Navigationendpoint14
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata34 commandMetadata { get; set; }
        public Browseendpoint8 browseEndpoint { get; set; }
    }

    public class Commandmetadata34
    {
        public Webcommandmetadata34 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata34
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint8
    {
        public string browseId { get; set; }
        public string canonicalBaseUrl { get; set; }
    }

    public class Button3
    {
        public Buttonrenderer15 buttonRenderer { get; set; }
    }

    public class Buttonrenderer15
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text15 text { get; set; }
        public Navigationendpoint15 navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text15
    {
        public Run40[] runs { get; set; }
    }

    public class Run40
    {
        public string text { get; set; }
    }

    public class Navigationendpoint15
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata35 commandMetadata { get; set; }
        public Modalendpoint3 modalEndpoint { get; set; }
    }

    public class Commandmetadata35
    {
        public Webcommandmetadata35 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata35
    {
        public bool ignoreNavigation { get; set; }
    }

    public class Modalendpoint3
    {
        public Modal3 modal { get; set; }
    }

    public class Modal3
    {
        public Modalwithtitleandbuttonrenderer3 modalWithTitleAndButtonRenderer { get; set; }
    }

    public class Modalwithtitleandbuttonrenderer3
    {
        public Title10 title { get; set; }
        public Content7 content { get; set; }
        public Button4 button { get; set; }
    }

    public class Title10
    {
        public string simpleText { get; set; }
    }

    public class Content7
    {
        public string simpleText { get; set; }
    }

    public class Button4
    {
        public Buttonrenderer16 buttonRenderer { get; set; }
    }

    public class Buttonrenderer16
    {
        public string style { get; set; }
        public string size { get; set; }
        public bool isDisabled { get; set; }
        public Text16 text { get; set; }
        public Navigationendpoint16 navigationEndpoint { get; set; }
        public string trackingParams { get; set; }
    }

    public class Text16
    {
        public string simpleText { get; set; }
    }

    public class Navigationendpoint16
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata36 commandMetadata { get; set; }
        public Signinendpoint4 signInEndpoint { get; set; }
    }

    public class Commandmetadata36
    {
        public Webcommandmetadata36 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata36
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
    }

    public class Signinendpoint4
    {
        public Nextendpoint3 nextEndpoint { get; set; }
        public string continueAction { get; set; }
        public string idamTag { get; set; }
    }

    public class Nextendpoint3
    {
        public string clickTrackingParams { get; set; }
        public Commandmetadata37 commandMetadata { get; set; }
        public Browseendpoint9 browseEndpoint { get; set; }
    }

    public class Commandmetadata37
    {
        public Webcommandmetadata37 webCommandMetadata { get; set; }
    }

    public class Webcommandmetadata37
    {
        public string url { get; set; }
        public string webPageType { get; set; }
        public int rootVe { get; set; }
        public string apiUrl { get; set; }
    }

    public class Browseendpoint9
    {
        public string browseId { get; set; }
    }
}
