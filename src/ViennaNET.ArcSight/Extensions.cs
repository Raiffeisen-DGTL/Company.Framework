﻿using System;
using System.Net;
using System.Net.NetworkInformation;

namespace ViennaNET.ArcSight
{
  /// <summary>
  /// Расширение сообщения в ArcSight в стандартном CEF-формате
  /// </summary>
  public class Extensions
  {
    public string Ipv6Address { get; set; }
    public string Ipv4Address { get; set; }
    public string MacAddress { get; set; }
    public string TimeStamp { get; set; }
    public string DeviceAction { get; set; }
    public IPAddress DeviceCustomIPv6Address1 { get; set; }
    public string DeviceCustomIPv6Address1Label { get; set; }
    public IPAddress DeviceCustomIPv6Address2 { get; set; }
    public string DeviceCustomIPv6Address2Label { get; set; }
    public IPAddress DeviceCustomIPv6Address3 { get; set; }
    public string DeviceCustomIPv6Address3Label { get; set; }
    public IPAddress DeviceCustomIPv6Address4 { get; set; }
    public string DeviceCustomIPv6Address4Label { get; set; }
    public string ApplicationProtocol { get; set; }
    public string DeviceEventCategory { get; set; }
    public double? DeviceCustomFloatingPoint1 { get; set; }
    public string DeviceCustomFloatingPoint1Label { get; set; }
    public double? DeviceCustomFloatingPoint2 { get; set; }
    public string DeviceCustomFloatingPoint2Label { get; set; }
    public double? DeviceCustomFloatingPoint3 { get; set; }
    public string DeviceCustomFloatingPoint3Label { get; set; }
    public double? DeviceCustomFloatingPoint4 { get; set; }
    public string DeviceCustomFloatingPoint4Label { get; set; }
    public long? DeviceCustomNumber1 { get; set; }
    public string DeviceCustomNumber1Label { get; set; }
    public long? DeviceCustomNumber2 { get; set; }
    public string DeviceCustomNumber2Label { get; set; }
    public long? DeviceCustomNumber3 { get; set; }
    public string DeviceCustomNumber3Label { get; set; }
    public int? BaseEventCount { get; set; }
    public string DeviceCustomString1 { get; set; }
    public string DeviceCustomString1Label { get; set; }
    public string DeviceCustomString2 { get; set; }
    public string DeviceCustomString2Label { get; set; }
    public string DeviceCustomString3 { get; set; }
    public string DeviceCustomString3Label { get; set; }
    public string DeviceCustomString4 { get; set; }
    public string DeviceCustomString4Label { get; set; }
    public string DeviceCustomString5 { get; set; }
    public string DeviceCustomString5Label { get; set; }
    public string DeviceCustomString6 { get; set; }
    public string DeviceCustomString6Label { get; set; }
    public string DestinationDnsDomain { get; set; }
    public string DestinationServiceName { get; set; }
    public IPAddress DestinationTranslatedAddress { get; set; }
    public int? DestinationTranslatedPort { get; set; }
    public DateTimeOffset? DeviceCustomDate1 { get; set; }
    public string DeviceCustomDate1Label { get; set; }
    public DateTimeOffset? DeviceCustomDate2 { get; set; }
    public string DeviceCustomDate2Label { get; set; }
    public string DeviceCustomDat21Label { get; set; }
    public DeviceDirection? DeviceDirection { get; set; }
    public string DeviceDnsDomain { get; set; }
    public string DeviceExternalId { get; set; }
    public string DeviceFacility { get; set; }
    public string DeviceInboundInterface { get; set; }
    public PhysicalAddress DeviceMacAddress { get; set; }
    public string DeviceNtDomain { get; set; }
    public string DeviceOutboundInterface { get; set; }
    public string DeviceProcessName { get; set; }
    public DateTimeOffset? DeviceReceiptTime { get; set; }
    public IPAddress DeviceTranslatedAddress { get; set; }
    public string DestinationHostName { get; set; }
    public PhysicalAddress DestinationMacAddress { get; set; }
    public string DestinationNtDomain { get; set; }
    public int? DestinationProcessId { get; set; }
    public string DestinationUserPrivileges { get; set; }
    public string DestinationProcessName { get; set; }
    public int? DestinationPort { get; set; }
    public IPAddress DestinationAddress { get; set; }
    public string DestinationUserID { get; set; }
    public string DestinationUserName { get; set; }
    public string DeviceTimeZone { get; set; }
    public IPAddress DeviceAddress { get; set; }
    public string DeviceHostName { get; set; }
    public int? DeviceProcessId { get; set; }
    public DateTimeOffset? EndTime { get; set; }
    public string ExternalId { get; set; }
    public DateTimeOffset? FlexDate1 { get; set; }
    public string FlexDate1Label { get; set; }
    public long? FlexNumber1 { get; set; }
    public string FlexNumber1Label { get; set; }
    public long? FlexNumber2 { get; set; }
    public string FlexNumber2Label { get; set; }
    public string FlexString1 { get; set; }
    public string FlexString1Label { get; set; }
    public string FlexString2 { get; set; }
    public string FlexString2Label { get; set; }
    public DateTimeOffset? FileCreateTime { get; set; }
    public string FileHash { get; set; }
    public string FileID { get; set; }
    public DateTimeOffset? FileModificationTime { get; set; }
    public string FilePath { get; set; }
    public string FilePermission { get; set; }
    public string FileType { get; set; }
    public string FileName { get; set; }
    public int? FileSize { get; set; }
    public int? BytesIn { get; set; }
    public string Message { get; set; }
    public DateTimeOffset? OldFileCreateTime { get; set; }
    public string OldFileHash { get; set; }
    public string OldFileId { get; set; }
    public DateTimeOffset? OldFileModificationTime { get; set; }
    public string OldFileName { get; set; }
    public string OldFilePath { get; set; }
    public string OldFilePermission { get; set; }
    public int? OldFileSize { get; set; }
    public string OldFileType { get; set; }
    public int? BytesOut { get; set; }
    public string EventOutcome { get; set; }
    public string TransportProtocol { get; set; }
    public string Reason { get; set; }
    public string RequestUrl { get; set; }
    public string RequestClientApplication { get; set; }
    public string RequestContext { get; set; }
    public string RequestCookies { get; set; }
    public string RequestMethod { get; set; }
    public string ReceiptTime { get; set; }
    public string SourceHostName { get; set; }
    public PhysicalAddress SourceMacAddress { get; set; }
    public string SourceNtDomain { get; set; }
    public string SourceDnsDomain { get; set; }
    public string SourceServiceName { get; set; }
    public IPAddress SourceTranslatedAddress { get; set; }
    public int? SourceTranslatedPort { get; set; }
    public int? SourceProcessId { get; set; }
    public string SourceUserPrivileges { get; set; }
    public string SourceProcessName { get; set; }
    public int? SourcePort { get; set; }
    public IPAddress SourceAddress { get; set; }
    public DateTimeOffset? StartTime { get; set; }
    public string SourceUserId { get; set; }
    public string SourceUserName { get; set; }
    public CefType? Type { get; set; }
    public string DevicePayloadId { get; set; }
  }
}