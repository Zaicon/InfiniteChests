namespace InfiniteChests
{
    public enum ChestAction : byte
	{
		None,
		GetInfo,
		Protect,
		SetPassword,
		SetRefill,
		SetBank,
		ToggleRegion,
		TogglePublic,
		Unprotect
	}
}
