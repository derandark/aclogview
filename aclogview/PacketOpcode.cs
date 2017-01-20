﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum PacketOpcode {
    Evt_Admin__CreateRare_ID = 1,
    NSP_NOTIFY_EVENT = 2,
    Evt_Allegiance__AllegianceUpdateAborted_ID = 3,
    Evt_Communication__PopUpString_ID = 4,
    Evt_Character__PlayerOptionChangedEvent_ID = 5,
    Evt_Admin__TeleportCharacterReturn_ID = 6,
    Evt_Combat__UntargetedMeleeAttack_ID = 7,
    Evt_Combat__TargetedMeleeAttack_ID = 8,
    OBJECT_STARTUP_EVENT = 9,
    Evt_Combat__TargetedMissileAttack_ID = 10,
    Evt_Combat__UntargetedMissileAttack_ID = 11,
    Evt_Admin__TeleportCharacterToMe_ID = 12,
    Evt_Admin__AdminCharDataByName_ID = 13,
    Evt_Admin__SetBodyPart_ID = 14,
    Evt_Communication__SetAFKMode_ID = 15,
    Evt_Communication__SetAFKMessage_ID = 16,
    PLAYER_DESCRIPTION_EVENT = 19,
    Evt_Communication__Talk_ID = 21,
    Evt_Social__RemoveFriend_ID = 23,
    Evt_Social__AddFriend_ID = 24,
    Evt_Inventory__PutItemInContainer_ID = 25,
    Evt_Inventory__GetAndWieldItem_ID = 26,
    Evt_Inventory__DropItem_ID = 27,
    WEENIE_ERROR_EVENT = 28,
    Evt_Allegiance__SwearAllegiance_ID = 29,
    Evt_Allegiance__BreakAllegiance_ID = 30,
    Evt_Allegiance__UpdateRequest_ID = 31,
    ALLEGIANCE_UPDATE_EVENT = 32,
    Evt_Social__FriendsUpdate_ID = 33,
    INVENTORY_PUT_OBJ_IN_CONTAINER_EVENT = 34,
    INVENTORY_WIELD_OBJ_EVENT = 35,
    INVENTORY_REMOVE_OBJ_EVENT = 36,
    Evt_Social__ClearFriends_ID = 37,
    Evt_Character__TeleToPKLArena_ID = 38,
    Evt_Character__TeleToPKArena_ID = 39,
    Evt_Social__AddCharacterTitle_ID = 40,
    Evt_Social__CharacterTitleTable_ID = 41,
    CHARACTER_GENERATION_RESULT_EVENT = 42,
    Evt_Social__AddOrSetCharacterTitle_ID = 43,
    Evt_Social__SetDisplayCharacterTitle_ID = 44,
    Evt_Admin__RemoveCharacterTitle_ID = 45,
    Evt_Admin__AddCharacterTitle_ID = 46,
    Evt_Admin__DumpCharacterTitles_ID = 47,
    Evt_Allegiance__QueryAllegianceName_ID = 48,
    Evt_Allegiance__ClearAllegianceName_ID = 49,
    Evt_Communication__TalkDirect_ID = 50,
    Evt_Allegiance__SetAllegianceName_ID = 51,
    CHAR_BASE_OBJDESC_EVENT = 52,
    Evt_Inventory__UseWithTargetEvent_ID = 53,
    Evt_Inventory__UseEvent_ID = 54,
    HEAR_TEXTBOX_SPEECH = 55,
    HEAR_TEXTBOX_SPEECH_DIRECT = 56,
    Evt_Admin__ResetAllegianceName_ID = 57,
    CHARACTER_LOGON_EVENT = 58,
    Evt_Allegiance__SetAllegianceOfficer_ID = 59,
    Evt_Allegiance__SetAllegianceOfficerTitle_ID = 60,
    Evt_Allegiance__ListAllegianceOfficerTitles_ID = 61,
    Evt_Allegiance__ClearAllegianceOfficerTitles_ID = 62,
    Evt_Allegiance__DoAllegianceLockAction_ID = 63,
    Evt_Allegiance__SetAllegianceApprovedVassal_ID = 64,
    Evt_Allegiance__AllegianceChatGag_ID = 65,
    Evt_Allegiance__DoAllegianceHouseAction_ID = 66,
    Evt_Train__TrainAttribute2nd_ID = 68,
    Evt_Train__TrainAttribute_ID = 69,
    Evt_Train__TrainSkill_ID = 70,
    Evt_Train__TrainSkillAdvancementClass_ID = 71,
    Evt_Magic__CastUntargetedSpell_ID = 72,
    Evt_Magic__CastTargetedSpell_ID = 74,
    Evt_Magic__ResearchSpell_ID = 75,
    UPDATE_SPELL_EVENT = 76,
    REMOVE_SPELL_EVENT = 77,
    UPDATE_ENCHANTMENT_EVENT = 78,
    REMOVE_ENCHANTMENT_EVENT = 79,
    Evt_Inventory__CommenceViewingContents_ID = 80,
    UPDATE_SPELL_TIMESTAMP_EVENT = 81,
    CLOSE_GROUND_CONTAINER_EVENT = 82,
    Evt_Combat__ChangeCombatMode_ID = 83,
    Evt_Inventory__StackableMerge_ID = 84,
    Evt_Inventory__StackableSplitToContainer_ID = 85,
    Evt_Inventory__StackableSplitTo3D_ID = 86,
    Evt_Communication__ModifyCharacterSquelch_ID = 88,
    Evt_Communication__ModifyAccountSquelch_ID = 89,
    Evt_Communication__SquelchQuery_ID = 90,
    Evt_Communication__ModifyGlobalSquelch_ID = 91,
    Evt_Communication__TalkDirectByName_ID = 93,
    ATTACK_NOTIFICATION_EVENT = 94,
    Evt_Vendor__Buy_ID = 95,
    Evt_Vendor__Sell_ID = 96,
    Evt_Vendor__RequestVendorInfo_ID = 97,
    VENDOR_INFO_EVENT = 98,
    Evt_Character__TeleToLifestone_ID = 99,
    Evt_Admin__InqWeenieDesc_ID = 100,
    Evt_Admin__SetPosition_ID = 101,
    Evt_Admin__SetSkill_ID = 102,
    Evt_Admin__SetDataID_ID = 103,
    Evt_Admin__SetString_ID = 104,
    Evt_Admin__SetFloat_ID = 105,
    Evt_Admin__SetInt_ID = 106,
    Evt_Admin__SetAttribute2nd_ID = 107,
    Evt_Admin__SetAttribute_ID = 108,
    Evt_Admin__Teleport_ID = 109,
    Evt_Admin__Create_ID = 112,
    Evt_Character__StartBarber_ID = 117,
    Evt_Admin__Delete_ID = 118,
    Evt_Admin__RaiseAttribute2nd_ID = 125,
    Evt_Admin__RaiseAttribute_ID = 126,
    Evt_Admin__RaiseSkill_ID = 127,
    Evt_Admin__RaiseXP_ID = 128,
    Evt_Admin__WeenieLogEvent_ID = 129,
    Evt_Admin__InqPlayerDataEvent_ID = 130,
    Evt_Admin__InqFullPlayerDataEvent_ID = 132,
    ADMIN_RECV_FULL_PLAYER_DATA_EVENT = 133,
    Evt_Admin__CloakRequest_ID = 134,
    Evt_Admin__PortalTeleport_ID = 135,
    Evt_Admin__SetInstanceID_ID = 136,
    Evt_Admin__StickyRequest_ID = 137,
    Evt_Admin__SetBool_ID = 138,
    ADMIN_RECV_WEENIE_DESC_EVENT = 150,
    ADMIN_RECV_POSITION_EVENT = 151,
    PORTAL_STORM_SUBSIDED_EVENT = 156,
    PORTAL_STORM_BREWING_EVENT = 157,
    PORTAL_STORM_IMMINENT_EVENT = 158,
    PORTAL_STORM_EVENT = 159,
    INVENTORY_SERVER_SAYS_FAILED_EVENT = 160,
    Evt_Character__LoginCompleteNotification_ID = 161,
    Evt_Fellowship__Create_ID = 162,
    Evt_Fellowship__Quit_ID = 163, // Bidirectional
    Evt_Fellowship__Dismiss_ID = 164, // Bidirectional
    Evt_Fellowship__Recruit_ID = 165,
    Evt_Fellowship__UpdateRequest_ID = 166,
    RECV_QUIT_FELLOW_EVENT = 167,
    Evt_Writing__BookData_ID = 170,
    Evt_Writing__BookModifyPage_ID = 171,
    Evt_Writing__BookAddPage_ID = 172,
    Evt_Writing__BookDeletePage_ID = 173,
    Evt_Writing__BookPageData_ID = 174,
    RECV_FELLOWSHIP_UPDATE_EVENT = 175,
    RECV_UPDATE_FELLOW_EVENT = 176,
    RECV_DISMISS_FELLOW_EVENT = 177,
    RECV_LOGOFF_FELLOW_EVENT = 178,
    RECV_DISBAND_FELLOWSHIP_EVENT = 179,
    BOOK_DATA_RESPONSE_EVENT = 180,
    BOOK_MODIFY_PAGE_RESPONSE_EVENT = 181,
    BOOK_ADD_PAGE_RESPONSE_EVENT = 182,
    BOOK_DELETE_PAGE_RESPONSE_EVENT = 183,
    BOOK_PAGE_DATA_RESPONSE_EVENT = 184,
    Evt_Writing__GetInscription_ID = 190,
    Evt_Writing__SetInscription_ID = 191,
    GET_INSCRIPTION_RESPONSE_EVENT = 195,
    Evt_Item__Appraise_ID = 200,
    APPRAISAL_INFO_EVENT = 201,
    Evt_Fellowship__Appraise_ID = 202,
    Evt_Inventory__GiveObjectRequest_ID = 205,
    Evt_Advocate__Bestow_ID = 211,
    Evt_Advocate__SetState_ID = 212,
    Evt_Advocate__SetAttackable_ID = 213,
    Evt_Advocate__Teleport_ID = 214,
    HEAR_LOCAL_SIGNALS_INT = 290,
    HEAR_LOCAL_SIGNALS_RADIUS_INT = 291,
    Evt_Character__AbuseLogRequest_ID = 320,
    Evt_Communication__AddToChannel_ID = 325,
    Evt_Communication__RemoveFromChannel_ID = 326,
    Evt_Communication__ChannelBroadcast_ID = 327, // Bidirectional
    Evt_Communication__ChannelList_ID = 328, // Bidirectional
    Evt_Communication__ChannelIndex_ID = 329, // Bidirectional
    CHANNEL_BROADCAST_EVENT = 330,
    CHANNEL_LIST_EVENT = 331,
    CHANNEL_INDEX_EVENT = 332,
    Evt_Inventory__NoLongerViewingContents_ID = 405,
    VIEW_CONTENTS_EVENT = 406,
    STACKABLE_SET_STACKSIZE_EVENT = 407,
    INVENTORY_PUT_OBJ_IN_3D_EVENT = 410,
    Evt_Inventory__StackableSplitToWield_ID = 411,
    Evt_Character__AddShortCut_ID = 412,
    Evt_Character__RemoveShortCut_ID = 413,
    PLAYER_DEATH_EVENT = 414,
    Evt_Character__CharacterOptionsEvent_ID = 417,
    Evt_Admin__SaveSanctuaryPosition_ID = 418,
    DISPEL_ENCHANTMENT_EVENT = 420,
    UPDATE_ENCHANTMENTS_EVENT = 421,
    REMOVE_ENCHANTMENTS_EVENT = 422,
    ATTACK_DONE_EVENT = 423,
    Evt_Magic__RemoveSpell_ID = 424, // Bidirectional
    PURGE_ENCHANTMENTS_EVENT = 427,
    VICTIM_NOTIFICATION_EVENT = 428,
    KILLER_NOTIFICATION_EVENT = 429,
    DISPEL_ENCHANTMENTS_EVENT = 430,
    ATTACKER_NOTIFICATION_EVENT = 433,
    DEFENDER_NOTIFICATION_EVENT = 434,
    EVASION_ATTACKER_NOTIFICATION_EVENT = 435,
    EVASION_DEFENDER_NOTIFICATION_EVENT = 436,
    HEAR_RANGED_TEXTBOX_SPEECH = 437,
    Evt_Admin__DumpEnemyTable_ID = 438,
    Evt_Combat__CancelAttack_ID = 439,
    Evt_Combat__CommenceAttack_ID = 440,
    Evt_Admin__Kill_ID = 441,
    Evt_Admin__DropAll_ID = 442,
    Evt_Admin__Dispel_ID = 443,
    Evt_Admin__Humble_ID = 444,
    Evt_Admin__QueryActive_ID = 445,
    Evt_Admin__QueryContext_ID = 446,
    Evt_Combat__QueryHealth_ID = 447,
    Evt_Combat__QueryHealthResponse_ID = 448,
    Evt_Admin__QueryHouseKeeping_ID = 449,
    Evt_Character__QueryAge_ID = 450,
    Evt_Character__QueryAgeResponse_ID = 451,
    Evt_Character__QueryBirth_ID = 452,
    Evt_Admin__QueryShop_ID = 454,
    Evt_Item__UseDone_ID = 455,
    Evt_Allegiance__AllegianceUpdateDone_ID = 456,
    Evt_Fellowship__FellowUpdateDone_ID = 457,
    Evt_Fellowship__FellowStatsDone_ID = 458,
    Evt_Item__AppraiseDone_ID = 459,
    Evt_Admin__QueryCPWorth_ID = 460,
    Evt_Admin__Heal_ID = 461,
    Evt_Admin__InqAccountDataEvent_ID = 462,
    Evt_Admin__Freeze_ID = 463,
    Evt_Admin__TeleportHome_ID = 464,
    Evt_Qualities__PrivateRemoveIntEvent_ID = 465,
    Evt_Qualities__RemoveIntEvent_ID = 466,
    Evt_Qualities__PrivateRemoveBoolEvent_ID = 467,
    Evt_Qualities__RemoveBoolEvent_ID = 468,
    Evt_Qualities__PrivateRemoveFloatEvent_ID = 469,
    Evt_Qualities__RemoveFloatEvent_ID = 470,
    Evt_Qualities__PrivateRemoveStringEvent_ID = 471,
    Evt_Qualities__RemoveStringEvent_ID = 472,
    Evt_Qualities__PrivateRemoveDataIDEvent_ID = 473,
    Evt_Qualities__RemoveDataIDEvent_ID = 474,
    Evt_Qualities__PrivateRemoveInstanceIDEvent_ID = 475,
    Evt_Qualities__RemoveInstanceIDEvent_ID = 476,
    Evt_Qualities__PrivateRemovePositionEvent_ID = 477,
    Evt_Qualities__RemovePositionEvent_ID = 478,
    Evt_Communication__Emote_ID = 479,
    Evt_Communication__HearEmote_ID = 480,
    Evt_Communication__SoulEmote_ID = 481,
    Evt_Communication__HearSoulEmote_ID = 482,
    Evt_Character__AddSpellFavorite_ID = 483,
    Evt_Character__RemoveSpellFavorite_ID = 484,
    Evt_Admin__ForceRegen_ID = 485,
    Evt_Advocate__TeleportTo_ID = 486,
    Evt_Admin__QueryMessage_ID = 487,
    Evt_Admin__QueryTime_ID = 488,
    Evt_Character__RequestPing_ID = 489,
    Evt_Character__ReturnPing_ID = 490,
    Evt_Admin__Gag_ID = 492,
    Evt_Admin__DumpQuestTable_ID = 493,
    Evt_Admin__WorldBroadcastEmote_ID = 494,
    Evt_Admin__LocalBroadcastEmote_ID = 495,
    Evt_Admin__DirectBroadcastEmote_ID = 496,
    Evt_Admin__QueryEventStatus_ID = 497,
    Evt_Admin__SetEventState_ID = 498,
    Evt_Communication__SetSquelchDB_ID = 500,
    Evt_Admin__CreateInternal_ID = 501,
    Evt_Trade__OpenTradeNegotiations_ID = 502,
    Evt_Trade__CloseTradeNegotiations_ID = 503,
    Evt_Trade__AddToTrade_ID = 504,
    Evt_Trade__RemoveFromTrade_ID = 505,
    Evt_Trade__AcceptTrade_ID = 506,
    Evt_Trade__DeclineTrade_ID = 507,
    Evt_Trade__DumpTrade_ID = 508,
    Evt_Trade__Recv_RegisterTrade_ID = 509,
    Evt_Trade__Recv_OpenTrade_ID = 510,
    Evt_Trade__Recv_CloseTrade_ID = 511,
    Evt_Trade__Recv_AddToTrade_ID = 512,
    Evt_Trade__Recv_RemoveFromTrade_ID = 513,
    Evt_Trade__Recv_AcceptTrade_ID = 514,
    Evt_Trade__Recv_DeclineTrade_ID = 515,
    Evt_Trade__ResetTrade_ID = 516,
    Evt_Trade__Recv_ResetTrade_ID = 517,
    Evt_Admin__QueryViewing_ID = 518,
    Evt_Trade__Recv_TradeFailure_ID = 519,
    Evt_Trade__Recv_ClearTradeAcceptance_ID = 520,
    Evt_Character__ClearPlayerConsentList_ID = 534,
    Evt_Character__DisplayPlayerConsentList_ID = 535,
    Evt_Character__RemoveFromPlayerConsentList_ID = 536,
    Evt_Character__AddPlayerPermission_ID = 537,
    Evt_Character__RemovePlayerPermission_ID = 538,
    Evt_House__DumpHouse_ID = 539,
    Evt_House__BuyHouse_ID = 540,
    Evt_House__Recv_HouseProfile_ID = 541,
    Evt_House__QueryHouse_ID = 542,
    Evt_House__AbandonHouse_ID = 543,
    Evt_House__StealHouse_ID = 544,
    Evt_House__RentHouse_ID = 545,
    Evt_House__LinkToHouse_ID = 546,
    Evt_House__ReCacheHouse_ID = 547,
    Evt_Character__SetDesiredComponentLevel_ID = 548,
    Evt_House__Recv_HouseData_ID = 549,
    Evt_House__Recv_HouseStatus_ID = 550,
    Evt_House__Recv_UpdateRentTime_ID = 551,
    Evt_House__Recv_UpdateRentPayment_ID = 552,
    UPDATE_INT_EVENT = 553,
    UPDATE_FLOAT_EVENT = 554,
    UPDATE_STRING_EVENT = 555,
    UPDATE_BOOL_EVENT = 556,
    UPDATE_IID_EVENT = 557,
    UPDATE_DID_EVENT = 558,
    UPDATE_POSITION_EVENT = 559,
    UPDATE_SKILL_EVENT = 560,
    UPDATE_SKILL_LEVEL_EVENT = 561,
    UPDATE_SAC_EVENT = 562,
    UPDATE_ATTRIBUTE_EVENT = 563,
    UPDATE_ATTRIBUTE_LEVEL_EVENT = 564,
    UPDATE_ATTRIBUTE_2ND_EVENT = 565,
    UPDATE_ATTRIBUTE_2ND_LEVEL_EVENT = 566,
    UPDATE_INT_PRIVATE_EVENT = 567,
    UPDATE_FLOAT_PRIVATE_EVENT = 568,
    UPDATE_STRING_PRIVATE_EVENT = 569,
    UPDATE_BOOL_PRIVATE_EVENT = 570,
    UPDATE_IID_PRIVATE_EVENT = 571,
    UPDATE_DID_PRIVATE_EVENT = 572,
    UPDATE_POSITION_PRIVATE_EVENT = 573,
    UPDATE_SKILL_PRIVATE_EVENT = 574,
    UPDATE_SKILL_LEVEL_PRIVATE_EVENT = 575,
    UPDATE_SAC_PRIVATE_EVENT = 576,
    UPDATE_ATTRIBUTE_PRIVATE_EVENT = 577,
    UPDATE_ATTRIBUTE_LEVEL_PRIVATE_EVENT = 578,
    UPDATE_ATTRIBUTE_2ND_PRIVATE_EVENT = 579,
    UPDATE_ATTRIBUTE_2ND_LEVEL_PRIVATE_EVENT = 580,
    Evt_House__AddPermanentGuest_Event_ID = 581,
    Evt_House__RemovePermanentGuest_Event_ID = 582,
    Evt_House__SetOpenHouseStatus_Event_ID = 583,
    Evt_House__Recv_UpdateRestrictions_ID = 584,
    Evt_House__ChangeStoragePermission_Event_ID = 585,
    Evt_House__BootSpecificHouseGuest_Event_ID = 586,
    Evt_House__BootAllUninvitedGuests_Event_ID = 587,
    Evt_House__RemoveAllStoragePermission_ID = 588,
    Evt_House__RequestFullGuestList_Event_ID = 589,
    Evt_House__RentPay_ID = 590,
    Evt_House__RentWarn_ID = 591,
    Evt_House__RentDue_ID = 592,
    Evt_Allegiance__SetMotd_ID = 596,
    Evt_Allegiance__QueryMotd_ID = 597,
    Evt_Allegiance__ClearMotd_ID = 598,
    Evt_House__Recv_UpdateHAR_ID = 599,
    Evt_House__QueryLord_ID = 600,
    Evt_House__Recv_HouseTransaction_ID = 601,
    Evt_House__RentOverDue_ID = 602,
    Evt_Admin__QueryInv_ID = 603,
    Evt_House__AddAllStoragePermission_ID = 604,
    Evt_House__QueryHouseOwner_ID = 605,
    Evt_House__RemoveAllPermanentGuests_Event_ID = 606,
    Evt_House__BootEveryone_Event_ID = 607,
    Evt_Admin__Orphan_ID = 608,
    Evt_House__AdminTeleToHouse_ID = 609,
    Evt_House__TeleToHouse_Event_ID = 610,
    Evt_Item__QueryItemMana_ID = 611,
    Evt_Item__QueryItemManaResponse_ID = 612,
    Evt_House__PayRentForAllHouses_ID = 613,
    Evt_House__SetHooksVisibility_ID = 614,
    Evt_House__ModifyAllegianceGuestPermission_ID = 615,
    Evt_House__ModifyAllegianceStoragePermission_ID = 616,
    Evt_Game__Join_ID = 617,
    Evt_Game__Quit_ID = 618,
    Evt_Game__Move_ID = 619,
    Evt_Game__MoveGrid_ID = 620,
    Evt_Game__MovePass_ID = 621,
    Evt_Game__Stalemate_ID = 622,
    Evt_Admin__CreateTreasure_ID = 623,
    Evt_House__ListAvailableHouses_ID = 624,
    Evt_House__Recv_AvailableHouses_ID = 625,
    Evt_Admin__TogglePortalBypass_ID = 626,
    Evt_Admin__Mutate_ID = 627,
    Evt_Character__ConfirmationRequest_ID = 628,
    Evt_Character__ConfirmationResponse_ID = 629,
    Evt_Character__ConfirmationDone_ID = 630,
    Evt_Allegiance__BreakAllegianceBoot_ID = 631,
    Evt_House__TeleToMansion_Event_ID = 632,
    Evt_Character__Suicide_ID = 633,
    Evt_Allegiance__AllegianceLoginNotificationEvent_ID = 634,
    Evt_Allegiance__AllegianceInfoRequest_ID = 635,
    Evt_Allegiance__AllegianceInfoResponseEvent_ID = 636,
    Evt_Inventory__CreateTinkeringTool_ID = 637,
    Evt_Admin__CreateMaterial_ID = 638,
    Evt_Admin__EraseQuestTable_ID = 639,
    Recv_Game__OpponentStalemateState_ID = 640,
    Evt_Game__Recv_JoinGameResponse_ID = 641,
    Evt_Game__Recv_StartGame_ID = 642,
    Evt_Game__Recv_MoveResponse_ID = 643,
    Evt_Game__Recv_OpponentTurn_ID = 644,
    Evt_Game__Recv_OppenentStalemateState_ID = 645,
    Evt_Character__SpellbookFilterEvent_ID = 646,
    Evt_Admin__QueryTrophyDrops_ID = 647,
    Evt_House__SetMaintenanceFree_ID = 648,
    Evt_House__DumpHouseAccess_ID = 649,
    Evt_Communication__WeenieError_ID = 650,
    Evt_Communication__WeenieErrorWithString_ID = 651,
    Evt_Game__Recv_GameOver_ID = 652,
    Evt_Character__TeleToMarketplace_ID = 653,
    Evt_Admin__StampQuest_ID = 654,
    Evt_Character__EnterPKLite_ID = 655,
    Evt_Fellowship__AssignNewLeader_ID = 656,
    Evt_Fellowship__ChangeFellowOpeness_ID = 657,
    Evt_Admin__ClearEvent_ID = 658,
    Evt_Admin__Limbo_ID = 659,
    Evt_Admin__SentinelRunBoost_ID = 660,
    Evt_Communication__Recv_ChatRoomTracker_ID = 661,
    Evt_Admin__PassupInfo_ID = 662,
    Evt_Admin__SetNeverHouseKept_ID = 663,
    Evt_Admin__SetCPWorth_ID = 664,
    Evt_Admin__SetDeafMode_ID = 665,
    Evt_Admin__SetDeafHear_ID = 666,
    Evt_Admin__SetDeafMute_ID = 667,
    Evt_Admin__SnoopOn_ID = 668,
    Evt_Admin__SetInvincibility_ID = 669,
    Evt_Admin__AssertTheServer_ID = 671,
    Evt_Allegiance__AllegianceChatBoot_ID = 672,
    Evt_Allegiance__AddAllegianceBan_ID = 673,
    Evt_Allegiance__RemoveAllegianceBan_ID = 674,
    Evt_Allegiance__ListAllegianceBans_ID = 675,
    Evt_Allegiance__AddAllegianceOfficer_ID = 676,
    Evt_Allegiance__RemoveAllegianceOfficer_ID = 677,
    Evt_Allegiance__ListAllegianceOfficers_ID = 678,
    Evt_Allegiance__ClearAllegianceOfficers_ID = 679,
    Evt_Admin__SavePosition_ID = 680,
    Evt_Admin__RecallPosition_ID = 681,
    Evt_Admin__AdminBoot_ID = 682,
    Evt_Allegiance__RecallAllegianceHometown_ID = 683,
    Evt_Admin__DumpRareTiers_ID = 684,
    Evt_Admin__QueryPluginList_ID = 685,
    Evt_Admin__Recv_QueryPluginList_ID = 686,
    Evt_Admin__QueryPluginListResponse_ID = 687,
    Evt_Admin__QueryPlugin_ID = 688,
    Evt_Admin__Recv_QueryPlugin_ID = 689,
    Evt_Admin__QueryPluginResponse_ID = 690,
    Evt_Admin__Recv_QueryPluginResponse_ID = 691,
    Evt_Inventory__Recv_SalvageOperationsResultData_ID = 692,
    Evt_Admin__SetInt64_ID = 693,
    UPDATE_INT64_EVENT = 694,
    UPDATE_INT64_PRIVATE_EVENT = 695,
    Evt_Qualities__PrivateRemoveInt64Event_ID = 696,
    Evt_Qualities__RemoveInt64Event_ID = 697,
    Evt_Admin__RaiseLevel_ID = 698,
    Evt_Communication__HearSpeech_ID = 699,
    Evt_Communication__HearRangedSpeech_ID = 700,
    Evt_Communication__HearDirectSpeech_ID = 701,
    Evt_Fellowship__FullUpdate_ID = 702,
    Evt_Fellowship__Disband_ID = 703,
    Evt_Fellowship__UpdateFellow_ID = 704,
    Evt_Magic__UpdateSpell_ID = 705,
    Evt_Magic__UpdateEnchantment_ID = 706,
    Evt_Magic__RemoveEnchantment_ID = 707,
    Evt_Magic__UpdateMultipleEnchantments_ID = 708,
    Evt_Magic__RemoveMultipleEnchantments_ID = 709,
    Evt_Magic__PurgeEnchantments_ID = 710,
    Evt_Magic__DispelEnchantment_ID = 711,
    Evt_Magic__DispelMultipleEnchantments_ID = 712,
    Evt_Misc__PortalStormBrewing_ID = 713,
    Evt_Misc__PortalStormImminent_ID = 714,
    Evt_Misc__PortalStorm_ID = 715,
    Evt_Misc__PortalStormSubsided_ID = 716,
    Evt_Qualities__PrivateUpdateInt_ID = 717,
    Evt_Qualities__UpdateInt_ID = 718,
    Evt_Qualities__PrivateUpdateInt64_ID = 719,
    Evt_Qualities__UpdateInt64_ID = 720,
    Evt_Qualities__PrivateUpdateBool_ID = 721,
    Evt_Qualities__UpdateBool_ID = 722,
    Evt_Qualities__PrivateUpdateFloat_ID = 723,
    Evt_Qualities__UpdateFloat_ID = 724,
    Evt_Qualities__PrivateUpdateString_ID = 725,
    Evt_Qualities__UpdateString_ID = 726,
    Evt_Qualities__PrivateUpdateDataID_ID = 727,
    Evt_Qualities__UpdateDataID_ID = 728,
    Evt_Qualities__PrivateUpdateInstanceID_ID = 729,
    Evt_Qualities__UpdateInstanceID_ID = 730,
    Evt_Qualities__PrivateUpdatePosition_ID = 731,
    Evt_Qualities__UpdatePosition_ID = 732,
    Evt_Qualities__PrivateUpdateSkill_ID = 733,
    Evt_Qualities__UpdateSkill_ID = 734,
    Evt_Qualities__PrivateUpdateSkillLevel_ID = 735,
    Evt_Qualities__UpdateSkillLevel_ID = 736,
    Evt_Qualities__PrivateUpdateSkillAC_ID = 737,
    Evt_Qualities__UpdateSkillAC_ID = 738,
    Evt_Qualities__PrivateUpdateAttribute_ID = 739,
    Evt_Qualities__UpdateAttribute_ID = 740,
    Evt_Qualities__PrivateUpdateAttributeLevel_ID = 741,
    Evt_Qualities__UpdateAttributeLevel_ID = 742,
    Evt_Qualities__PrivateUpdateAttribute2nd_ID = 743,
    Evt_Qualities__UpdateAttribute2nd_ID = 744,
    Evt_Qualities__PrivateUpdateAttribute2ndLevel_ID = 745,
    Evt_Qualities__UpdateAttribute2ndLevel_ID = 746,
    Evt_Communication__TransientString_ID = 747,
    Evt_Admin__ForceRenameCharacter_ID = 780,
    Evt_Admin__GagTime_ID = 781,
    Evt_Admin__AddRenameToken_ID = 782,
    Evt_Character__Rename_ID = 783,
    Evt_Character__FinishBarber_ID = 785,
    Evt_Magic__PurgeBadEnchantments_ID = 786,
    Evt_Social__SendClientContractTrackerTable_ID = 788,
    Evt_Social__SendClientContractTracker_ID = 789,
    Evt_Social__AbandonContract_ID = 790,
    Evt_Admin__Environs_ID = 60000,
    Evt_Movement__PositionAndMovement_ID = 63001,
    Evt_Movement__Jump_ID = 63003,
    Evt_Movement__MoveToState_ID = 63004,
    Evt_Movement__DoMovementCommand_ID = 63006,
    Evt_Physics__ObjDescEvent_ID = 63013,
    USER_ALERT_EVENT = 63024,
    CHARACTER_GENERATION_VERIFICATION_RESPONSE_EVENT = 63043,
    Evt_Movement__TurnEvent_ID = 63048,
    Evt_Movement__TurnToEvent_ID = 63049,
    EXPIRE_WARNING_EVENT = 63057,
    CHARACTER_EXIT_GAME_EVENT = 63059, // Bidirectional
    CHARACTER_PREVIEW_EVENT = 63060,
    CHARACTER_DELETE_EVENT = 63061, // Bidirectional
    CHARACTER_CREATE_EVENT = 63062,
    CHARACTER_ENTER_GAME_EVENT = 63063,
    Evt_Login__CharacterSet_ID = 63064,
    CHARACTER_ERROR_EVENT = 63065,
    SYSTEM_MESSAGES_EVENT = 63066,
    Evt_Movement__StopMovementCommand_ID = 63073,
    ADMIN_RECV_PLAYER_DATA_EVENT = 63131,
    CONTROL_FORCE_OBJDESC_SEND_EVENT = 63210,
    Evt_Physics__CreateObject_ID = 63301,
    Evt_Physics__CreatePlayer_ID = 63302,
    Evt_Physics__DeleteObject_ID = 63303,
    Evt_Movement__UpdatePosition_ID = 63304,
    Evt_Physics__ParentEvent_ID = 63305,
    Evt_Physics__PickupEvent_ID = 63306,
    Evt_Physics__SetState_ID = 63307,
    Evt_Movement__MovementEvent_ID = 63308,
    Evt_Physics__VectorUpdate_ID = 63310,
    Evt_Physics__SoundEvent_ID = 63312,
    Evt_Physics__PlayerTeleport_ID = 63313,
    Evt_Movement__AutonomyLevel_ID = 63314,
    Evt_Movement__AutonomousPosition_ID = 63315,
    Evt_Physics__PlayScriptID_ID = 63316,
    Evt_Physics__PlayScriptType_ID = 63317,
    LBDB_STATUS_CLIENT_EVENT = 63333,
    CLIDAT_REQUEST_DATA_EVENT = 63400,
    CLIDAT_REQUEST_CELL_EVENT = 63401,
    CLIDAT_ERROR_EVENT = 63402,
    CLIDAT_LANDBLOCK_EVENT = 63403,
    CLIDAT_CELL_EVENT = 63404,
    WEENIE_ORDERED_EVENT = 63408,
    ORDERED_EVENT = 63409,
    CLIDAT_DATA_EVENT = 63415,
    CLIDAT_CELL_PURGE_EVENT = 63419,
    ACCOUNT_BANNED_EVENT = 63425,
    CLIENT_LOGON_SERVER_EVENT = 63426,
    CHARDB_READY_TO_ENTER_GAME_EVENT = 63431,
    CLIENT_REQUEST_ENTER_GAME_EVENT = 63432,
    Evt_Movement__Jump_NonAutonomous_ID = 63433,
    Evt_Admin__ReceiveAccountData_ID = 63434,
    Evt_Admin__ReceivePlayerData_ID = 63435,
    Evt_Admin__GetServerVersion_ID = 63436,
    Evt_Admin__Friends_ID = 63437,
    Evt_Admin__ReloadSystemMessages_ID = 63438,
    Evt_Admin__SetUserLimit_ID = 63439,
    Evt_Admin__SetLoadBalanceInterval_ID = 63440,
    Evt_Admin__SetLoadBalanceThreshold_ID = 63441,
    Evt_Admin__SetPortalStormThreshold_ID = 63442,
    Evt_Admin__SetPortalStormNumToMove_ID = 63443,
    Evt_Admin__FingerCharacter_ID = 63444,
    Evt_Admin__FingerAccount_ID = 63445,
    Evt_Admin__AdminLevelList_ID = 63446,
    Evt_Admin__CopyCharacter_ID = 63447,
    Evt_Admin__AdminNextIDsList_ID = 63448,
    Evt_Admin__AdminRestoreCharacter_ID = 63449,
    Evt_Admin__QueryBannedList_ID = 63450,
    Evt_Physics__UpdateObject_ID = 63451,
    ACCOUNT_BOOTED_EVENT = 63452,
    Evt_Admin__ClearLocks_ID = 63453,
    Evt_Admin__ChatServerData_ID = 63454, // Bidirectional
    Evt_Character__EnterGame_ServerReady_ID = 63455,
    Evt_Communication__TextboxString_ID = 63456,
    Evt_Login__WorldInfo_ID = 63457,
    Evt_DDD__Data_ID = 63458,
    Evt_DDD__RequestData_ID = 63459,
    Evt_DDD__Error_ID = 63460,
    Evt_DDD__Interrogation_ID = 63461,
    Evt_DDD__InterrogationResponse_ID = 63462,
    Evt_DDD__BeginDDD_ID = 63463,
    Evt_DDD__BeginPullDDD_ID = 63464,
    Evt_DDD__IterationData_ID = 63465,
    Evt_DDD__EndDDD_ID = 63466,
    Evt_DDD__Pending_ID = 63467

    // sendtocontrol = 2
    // weenie = 3
    // logon = 4
    // database = 5
}
