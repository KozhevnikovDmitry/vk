﻿// Autogenerated at 28.08.2014 11:36:44
// DO NOT EDIT THIS FILE CAUSE ALL CHANGES WILL BE DELETED AUTOMATICALLY
using VkNet.Enums.SafetyEnums;
namespace VkNet.Utils
{
    partial class VkResponse
    {
		public static implicit operator GroupType(VkResponse response)
		{
            return response == null ? null :  GroupType.FromJson(response);
        }
		public static implicit operator LinkAccessType(VkResponse response)
		{
            return response == null ? null :  LinkAccessType.FromJson(response);
        }

	}
}