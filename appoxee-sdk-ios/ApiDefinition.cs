using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Appoxee
{
    // @protocol AppoxeeDelegate <NSObject>
    [Protocol, Model]
    [BaseType (typeof(NSObject))]
    interface AppoxeeDelegate
    {
        // @required -(NSString *)AppoxeeDelegateAppSDKID;
        [Abstract]
        [Export ("AppoxeeDelegateAppSDKID")]
        string AppoxeeDelegateAppSDKID { get; }

        // @required -(NSString *)AppoxeeDelegateAppSecret;
        [Abstract]
        [Export ("AppoxeeDelegateAppSecret")]
        string AppoxeeDelegateAppSecret { get; }

        // @required -(void)appNeedsToRegisterForPush;
        [Abstract]
        [Export ("appNeedsToRegisterForPush")]
        void AppNeedsToRegisterForPush ();

        // @optional -(void)AppoxeeDelegateReciveAppoxeeClosed;
        [Export ("AppoxeeDelegateReciveAppoxeeClosed")]
        void AppoxeeDelegateReceiveAppoxeeClosed ();

        // @optional -(void)AppoxeeDelegateReciveAppoxeeRequestFocus;
        [Export ("AppoxeeDelegateReciveAppoxeeRequestFocus")]
        void AppoxeeDelegateReceiveAppoxeeRequestFocus ();

        // @optional -(void)AppoxeeNeedsToUpdateBadge:(int)badgeNum hasNumberChanged:(BOOL)hasNumberChanged;
        [Export ("AppoxeeNeedsToUpdateBadge:hasNumberChanged:")]
        void AppoxeeNeedsToUpdateBadge (int badgeNum, bool hasNumberChanged);

        // @optional -(BOOL)shouldAppoxeeRotateToInterfaceOrientation:(UIInterfaceOrientation)toInterfaceOrientation;
        [Export ("shouldAppoxeeRotateToInterfaceOrientation:")]
        bool ShouldAppoxeeRotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation);

        // @optional -(void)appDidOpenFromPushNotification:(NSDictionary *)userInfo;
        [Export ("appDidOpenFromPushNotification:")]
        void AppDidOpenFromPushNotification (NSDictionary userInfo);

        // @optional -(void)appoxeeInteractivePushNotificationPressedWithCategory:(NSString *)category andPayload:(NSDictionary *)pushPayload;
        [Export ("appoxeeInteractivePushNotificationPressedWithCategory:andPayload:")]
        void AppoxeeInteractivePushNotificationPressedWithCategory (string category, NSDictionary pushPayload);

        // @optional -(void)appoxeeInteractivePushButton1PressedWithCategory:(NSString *)category andPayload:(NSDictionary *)pushPayload;
        [Export ("appoxeeInteractivePushButton1PressedWithCategory:andPayload:")]
        void AppoxeeInteractivePushButton1PressedWithCategory (string category, NSDictionary pushPayload);

        // @optional -(void)appoxeeInteractivePushButton2PressedWithCategory:(NSString *)category andPayload:(NSDictionary *)pushPayload;
        [Export ("appoxeeInteractivePushButton2PressedWithCategory:andPayload:")]
        void AppoxeeInteractivePushButton2PressedWithCategory (string category, NSDictionary pushPayload);
    }

    // @interface AppoxeeManager : NSObject
    [BaseType (typeof(NSObject))]
    interface AppoxeeManager
    {
        // +(id)sharedManager;
        [Static]
        [Export ("sharedManager")]
        AppoxeeManager SharedManager { get; }

        bool AutomaticallyClearNotifications
        {
            // +(void)automaticallyClearNotifications:(BOOL)automatically;
            [Static]
            [Export ("automaticallyClearNotifications:")]
            set;

            // +(BOOL)isNotificationsClearedAutomatically;
            [Static]
            [Export ("isNotificationsClearedAutomatically")]
            get;
        }

        // -(void)initManagerWithDelegate:(id<AppoxeeDelegate>)d andOptions:(NSDictionary *)options;
        [Export ("initManagerWithDelegate:andOptions:")]
        void InitManagerWithDelegate (AppoxeeDelegate d, [NullAllowed] NSDictionary options);

        // -(BOOL)managerParseLaunchOptions:(NSDictionary *)launchOptions;
        [Export ("managerParseLaunchOptions:")]
        bool ManagerParseLaunchOptions ([NullAllowed] NSDictionary launchOptions);

        // -(void)didRegisterForRemoteNotificationsWithDeviceToken:(NSData *)token;
        [Export ("didRegisterForRemoteNotificationsWithDeviceToken:")]
        void DidRegisterForRemoteNotificationsWithDeviceToken (NSData token);

        // -(BOOL)didReceiveRemoteNotification:(NSDictionary *)userInfo;
        [Export ("didReceiveRemoteNotification:")]
        bool DidReceiveRemoteNotification (NSDictionary userInfo);

        // -(void)didReceiveLocalNotification:(UILocalNotification *)notification;
        [Export ("didReceiveLocalNotification:")]
        void DidReceiveLocalNotification (UILocalNotification notification);

        // -(BOOL)handleActionWithIdentifier:(NSString *)identifier forRemoteNotification:(NSDictionary *)userInfo completionHandler:(void (^)())completionHandler;
        [Export ("handleActionWithIdentifier:forRemoteNotification:completionHandler:")]
        bool HandleActionWithIdentifier (string identifier, NSDictionary userInfo, Action completionHandler);

        // -(void)show;
        [Export ("show")]
        void Show ();

        // -(BOOL)showMoreAppsViewController;
        [Export ("showMoreAppsViewController")]
        bool ShowMoreAppsViewController();

        // -(BOOL)showFeedbackViewController;
        [Export ("showFeedbackViewController")]
        bool ShowFeedbackViewController();

        // -(void)showMoreAppsOnInbox:(BOOL)show;
        [Export ("showMoreAppsOnInbox:")]
        void ShowMoreAppsOnInbox (bool show);

        // -(void)showFeedbackOnInbox:(BOOL)show;
        [Export ("showFeedbackOnInbox:")]
        void ShowFeedbackOnInbox (bool show);

        // -(UIViewController *)getAppoxeeViewController;
        [Export ("getAppoxeeViewController")]
        UIViewController AppoxeeViewController { get; }

        // -(UIViewController *)getAppoxeeMoreAppsViewController;
        [Export ("getAppoxeeMoreAppsViewController")]
        UIViewController AppoxeeMoreAppsViewController { get; }

        // -(UIViewController *)getAppoxeeFeedbackViewController;
        [Export ("getAppoxeeFeedbackViewController")]
        UIViewController AppoxeeFeedbackViewController { get; }

        // -(void)recalculateUnreadMessagesBadge;
        [Export ("recalculateUnreadMessagesBadge")]
        void RecalculateUnreadMessagesBadge ();

        // -(void)statusBar:(BOOL)status :(UIViewController *)rootVC;
        [Export ("statusBar::")]
        void StatusBar (bool status, UIViewController rootVC);

        // -(void)setUsingCustomInbox:(BOOL)isCustom;
        [Export ("setUsingCustomInbox:")]
        void SetUsingCustomInbox (bool isCustom);

        // -(BOOL)getUsingCustomInboxFlag;
        [Export ("getUsingCustomInboxFlag")]
        bool UsingCustomInboxFlag { get; }

        // -(void)showCustomInbox:(BOOL)show;
        [Export ("showCustomInbox:")]
        void ShowCustomInbox (bool show);

        // -(void)addBadgeToView:(UIView *)badgeView badgeText:(NSString *)badgeText badgeLocation:(CGPoint)badgeLocation;
        [Export ("addBadgeToView:badgeText:badgeLocation:")]
        void AddBadgeToView (UIView badgeView, string badgeText, CGPoint badgeLocation);

        // -(void)addBadgeToView:(UIView *)badgeView badgeText:(NSString *)badgeText badgeLocation:(CGPoint)badgeLocation shouldFlashBadge:(BOOL)shouldFlashBadge;
        [Export ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:")]
        void AddBadgeToView (UIView badgeView, string badgeText, CGPoint badgeLocation, bool shouldFlashBadge);

        // -(void)addBadgeToView:(UIView *)badgeView badgeText:(NSString *)badgeText badgeLocation:(CGPoint)badgeLocation shouldFlashBadge:(BOOL)shouldFlashBadge withFontSize:(float)fontSize;
        [Export ("addBadgeToView:badgeText:badgeLocation:shouldFlashBadge:withFontSize:")]
        void AddBadgeToView (UIView badgeView, string badgeText, CGPoint badgeLocation, bool shouldFlashBadge, float fontSize);

        // -(NSArray *)getInboxMessages;
        [Export ("getInboxMessages")]
        AppoxeeMessage[] InboxMessages { get; }

        // -(void)openAppoxeeMessage:(AppoxeeMessage *)appoxeeMessage;
        [Export ("openAppoxeeMessage:")]
        void OpenAppoxeeMessage (AppoxeeMessage appoxeeMessage);

        // -(void)deleteAppoxeeMessage:(AppoxeeMessage *)appoxeeMessage;
        [Export ("deleteAppoxeeMessage:")]
        void DeleteAppoxeeMessage (AppoxeeMessage appoxeeMessage);

        // -(BOOL)addTagsToDevice:(NSArray *)tagsToAdd andRemove:(NSArray *)tagsToRemove;
        [Export ("addTagsToDevice:andRemove:")]
        bool AddTagsToDevice (NSString[] tagsToAdd, NSString[] tagsToRemove);

        // -(BOOL)addTagsToDevice:(NSArray *)tags;
        [Export ("addTagsToDevice:")]
        bool AddTagsToDevice (NSString[] tags);

        // -(BOOL)removeTagsFromDevice:(NSArray *)tags;
        [Export ("removeTagsFromDevice:")]
        bool RemoveTagsFromDevice (NSString[] tags);

        // -(NSArray *)getDeviceTags;
        [Export ("getDeviceTags")]
        NSString[] DeviceTags { get; }

        // -(NSArray *)getTagList;
        [Export ("getTagList")]
        NSString[] TagList { get; }

        // -(void)clearTagsCache;
        [Export ("clearTagsCache")]
        void ClearTagsCache ();

        // -(BOOL)setDeviceAlias:(NSString *)alias;
        [Export ("setDeviceAlias:")]
        bool SetDeviceAlias (string alias);

        // -(BOOL)removeDeviceAlias;
        [Export ("removeDeviceAlias")]
        bool RemoveDeviceAlias();

        // -(NSString *)getDeviceAlias;
        [Export ("getDeviceAlias")]
        string DeviceAlias { get; }

        // -(void)clearAliasCache;
        [Export ("clearAliasCache")]
        void ClearAliasCache ();

        // -(NSString *)getDeviceOsName;
        [Export ("getDeviceOsName")]
        string DeviceOsName { get; }

        // -(NSString *)getDeviceOsNumber;
        [Export ("getDeviceOsNumber")]
        string DeviceOsNumber { get; }

        // -(NSString *)getHardwareType;
        [Export ("getHardwareType")]
        string HardwareType { get; }

        // -(NSString *)getDeviceCountry;
        [Export ("getDeviceCountry")]
        string DeviceCountry { get; }

        // -(int)getDeviceActivations;
        [Export ("getDeviceActivations")]
        int DeviceActivations { get; }

        // -(NSDecimalNumber *)getInAppPayment;
        [Export ("getInAppPayment")]
        NSDecimalNumber InAppPayment { get; }

        // -(int)getNumProductsPurchased;
        [Export ("getNumProductsPurchased")]
        int NumProductsPurchased { get; }

        // -(BOOL)increaseInAppPayment:(NSDecimalNumber *)payment andNumPurchased:(NSDecimalNumber *)numPurchased;
        [Export ("increaseInAppPayment:andNumPurchased:")]
        bool IncreaseInAppPayment (NSDecimalNumber payment, NSDecimalNumber numPurchased);

        // -(BOOL)increaseNumProductPurchased:(NSDecimalNumber *)payment;
        [Export ("increaseNumProductPurchased:")]
        bool IncreaseNumProductPurchased (NSDecimalNumber payment);

        // -(NSString *)getApplicationID;
        [Export ("getApplicationID")]
        string ApplicationID { get; }

        // -(int)getInboxFlag;
        [Export ("getInboxFlag")]
        int InboxFlag { get; }

        // -(int)getCustomInboxFlag;
        [Export ("getCustomInboxFlag")]
        int CustomInboxFlag { get; }

        // -(NSString *)getDeviceUniqueID;
        [Export ("getDeviceUniqueID")]
        string DeviceUniqueID { get; }

        // -(int)getFeedbackFlag;
        [Export ("getFeedbackFlag")]
        int FeedbackFlag { get; }

        // -(int)getMoreAppsFlag;
        [Export ("getMoreAppsFlag")]
        int MoreAppsFlag { get; }

        // -(BOOL)isPushEnabled;
        [Export ("isPushEnabled")]
        bool IsPushEnabled { get; }

        // -(BOOL)isSoundEnabled;
        [Export ("isSoundEnabled")]
        bool IsSoundEnabled { get; }

        // -(BOOL)isBadgeEnabled;
        [Export ("isBadgeEnabled")]
        bool IsBadgeEnabled { get; }

        // -(BOOL)isInboxEnabled;
        [Export ("isInboxEnabled")]
        bool IsInboxEnabled { get; }

        // -(BOOL)isCoppaShown;
        [Export ("isCoppaShown")]
        bool IsCoppaShown { get; }

        // -(void)setPushEnabled:(BOOL)enabled;
        [Export ("setPushEnabled:")]
        void SetPushEnabled (bool enabled);

        // -(void)setSoundEnabled:(BOOL)enabled;
        [Export ("setSoundEnabled:")]
        void SetSoundEnabled (bool enabled);

        // -(void)setBadgeEnabled:(BOOL)enabled;
        [Export ("setBadgeEnabled:")]
        void SetBadgeEnabled (bool enabled);

        // -(void)setInboxEnabled:(BOOL)enabled;
        [Export ("setInboxEnabled:")]
        void SetInboxEnabled (bool enabled);

        // -(BOOL)setDateFields:(NSMutableDictionary *)datesDict;
        [Export ("setDateFields:")]
        bool SetDateFields (NSMutableDictionary datesDict);

        // -(BOOL)setNumericFields:(NSMutableDictionary *)numericValuesDict;
        [Export ("setNumericFields:")]
        bool SetNumericFields (NSMutableDictionary numericValuesDict);

        // -(BOOL)incNumericFields:(NSMutableDictionary *)numericValuesDict;
        [Export ("incNumericFields:")]
        bool IncNumericFields (NSMutableDictionary numericValuesDict);

        // -(BOOL)setStringFields:(NSMutableDictionary *)stringValuesDict;
        [Export ("setStringFields:")]
        bool SetStringFields (NSMutableDictionary stringValuesDict);

        // -(UIRemoteNotificationType)getNotificationStatus;
        [Export ("getNotificationStatus")]
        UIRemoteNotificationType NotificationStatus { get; }

        // -(void)setQuietTime:(NSString *)startTimeParam endTime:(NSString *)endTimeParam;
        [Export ("setQuietTime:endTime:")]
        void SetQuietTime (string startTimeParam, string endTimeParam);

        // -(NSString *)getSplashScreen;
        [Export ("getSplashScreen")]
        string SplashScreen { get; }

        // -(NSString *)getPoweredByImageLink;
        [Export ("getPoweredByImageLink")]
        string PoweredByImageLink { get; }

        // -(NSString *)getQuietTimeStart;
        [Export ("getQuietTimeStart")]
        string QuietTimeStart { get; }

        // -(NSString *)getQuietTimeEnd;
        [Export ("getQuietTimeEnd")]
        string QuietTimeEnd { get; }

        // -(void)optOutBadge:(BOOL)flag;
        [Export ("optOutBadge:")]
        void OptOutBadge (bool flag);

        // -(void)optOutSound:(BOOL)flag;
        [Export ("optOutSound:")]
        void OptOutSound (bool flag);

        // -(void)SplashScreen;
        [Export ("SplashScreen")]
        void ShowSplashScreen ();

        // -(void)optOutInbox:(BOOL)flag;
        [Export ("optOutInbox:")]
        void OptOutInbox (bool flag);

        // -(void)optOutPush:(BOOL)flag;
        [Export ("optOutPush:")]
        void OptOutPush (bool flag);

        // -(void)optOutQuietTime;
        [Export ("optOutQuietTime")]
        void OptOutQuietTime ();

        // -(void)configureAppoxeeForLocale:(NSString *)theLocale;
        [Export ("configureAppoxeeForLocale:")]
        void ConfigureAppoxeeForLocale (string theLocale);

        // -(NSString *)getAttribute:(NSString *)param;
        [Export ("getAttribute:")]
        string GetAttribute (string param);

        // -(NSString *)getCustomFieldByKey:(NSString *)key;
        [Export ("getCustomFieldByKey:")]
        string GetCustomFieldByKey (string key);

        // -(NSArray *)setAttributeWithDict:(NSMutableDictionary *)param andKey:(NSString *)keyParam;
        [Export ("setAttributeWithDict:andKey:")]
        NSObject[] SetAttributeWithDict (NSMutableDictionary param, string keyParam);

        // -(NSString *)getServerV3URL;
        [Export ("getServerV3URL")]
        string ServerV3URL { get; }

        // -(NSString *)getGateKeeperURL;
        [Export ("getGateKeeperURL")]
        string GateKeeperURL { get; }

        // -(NSString *)getServerV2URL;
        [Export ("getServerV2URL")]
        string ServerV2URL { get; }

        // -(NSString *)getMoreAppsURL;
        [Export ("getMoreAppsURL")]
        string MoreAppsURL { get; }

        // -(NSString *)getFeedbackURL;
        [Export ("getFeedbackURL")]
        string FeedbackURL { get; }

        // -(NSString *)getDeviceDefURL;
        [Export ("getDeviceDefURL")]
        string DeviceDefURL { get; }

        // -(NSString *)getDeviceAdsURL;
        [Export ("getDeviceAdsURL")]
        string DeviceAdsURL { get; }

        // -(void)disableFeedbackAndMoreApps:(BOOL)shouldDisable;
        [Export ("disableFeedbackAndMoreApps:")]
        void DisableFeedbackAndMoreApps (bool shouldDisable);
    }

    partial interface Constants
    {
        // extern NSString *const AppoxeeManagerModalParam;
        [Field ("AppoxeeManagerModalParam")]
        NSString AppoxeeManagerModalParam { get; }

        // extern NSString *const AppoxeeManagerViewHeightParam;
        [Field ("AppoxeeManagerViewHeightParam")]
        NSString AppoxeeManagerViewHeightParam { get; }

        // extern NSString *const AppoxeeManagerNewMailSoundFileName;
        [Field ("AppoxeeManagerNewMailSoundFileName")]
        NSString AppoxeeManagerNewMailSoundFileName { get; }

        // extern NSString *const AppoxeeManagerViewAnimationTypeParam;
        [Field ("AppoxeeManagerViewAnimationTypeParam")]
        NSString AppoxeeManagerViewAnimationTypeParam { get; }

        // extern NSString *const AppoxeeManagerViewAnimationTypeParam_PageCurl;
        [Field ("AppoxeeManagerViewAnimationTypeParam_PageCurl")]
        NSString AppoxeeManagerViewAnimationTypeParam_PageCurl { get; }

        // extern NSString *const AppoxeeManagerViewAnimationTypeParam_VerticalMove;
        [Field ("AppoxeeManagerViewAnimationTypeParam_VerticalMove")]
        NSString AppoxeeManagerViewAnimationTypeParam_VerticalMove { get; }
    }

    // @interface AppoxeeMessage : NSObject
    [BaseType (typeof(NSObject))]
    interface AppoxeeMessage
    {
        // @property (retain, nonatomic) NSString * messageHeader;
        [Export ("messageHeader", ArgumentSemantic.Retain)]
        string MessageHeader { get; set; }

        // @property (retain, nonatomic) NSString * messageDescription;
        [Export ("messageDescription", ArgumentSemantic.Retain)]
        string MessageDescription { get; set; }

        // @property (retain, nonatomic) NSString * messageGroupID;
        [Export ("messageGroupID", ArgumentSemantic.Retain)]
        string MessageGroupID { get; set; }

        // @property (retain, nonatomic) NSString * messageType;
        [Export ("messageType", ArgumentSemantic.Retain)]
        string MessageType { get; set; }

        // @property (retain, nonatomic) NSDate * messagePostDate;
        [Export ("messagePostDate", ArgumentSemantic.Retain)]
        NSDate MessagePostDate { get; set; }

        // @property (retain, nonatomic) NSDate * messageUpdateDate;
        [Export ("messageUpdateDate", ArgumentSemantic.Retain)]
        NSDate MessageUpdateDate { get; set; }

        // @property (nonatomic) BOOL isMessageOpened;
        [Export ("isMessageOpened")]
        bool IsMessageOpened { get; set; }

        // @property (nonatomic) BOOL isMessageOpenedCustomInbox;
        [Export ("isMessageOpenedCustomInbox")]
        bool IsMessageOpenedCustomInbox { get; set; }

        // -(NSString *)getMessageLinkAndReportToServer;
        [Export ("getMessageLinkAndReportToServer")]
        string GetMessageLinkAndReportToServer();
    }
}