﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.D3.MemoryModel
{
	public struct SymbolTable
	{
		public static SymbolTable Current;

		public SymbolTable(MemoryContext ctx)
			: this(ctx.Memory.Reader.PointerSize == 8 ? Platform.X64 : Platform.X86) { }

		public SymbolTable(Platform platform)
		{
			Version = new Version(2, 4, 3, 43048);
			Platform = platform;

			DataSegment = new DataSegmentSymbols(platform);
			ObjectManager = new ObjectManagerSymbols(platform);
			Actor = new ActorSymbols(platform);
			ACDManager = new ACDManagerSymbols(platform);
			ACD = new ACDSymbols(platform);
			LocalData = new LocalDataSymbols(platform);
			FastAttrib = new FastAttribSymbols(platform);
			FastAttribGroup = new FastAttribGroupSymbols(platform);
			PlayerDataManager = new PlayerDataManagerSymbols(platform);
			PlayerData = new PlayerDataSymbols(platform);
			Scene = new SceneSymbols(platform);
			World = new WorldSymbols(platform);
			QuestManager = new QuestManagerSymbols(platform);
			Quest = new QuestSymbols(platform);
			WaypointManager = new WaypointManagerSymbols(platform);
			Waypoint = new WaypointSymbols(platform);
			TrickleManager = new TrickleManagerSymbols(platform);
			Trickle = new TrickleSymbols(platform);
			UIManager = new UIManagerSymbols(platform);
			LevelArea = new LevelAreaSymbols(platform);
			Player = new PlayerSymbols(platform);
			AttributeDescriptor = new AttributeDescriptorSymbols(platform);
			FloatingNumber = new FloatingNumberSymbols(platform);
			TimedEvent = new TimedEventSymbols(platform);
			MemoryManager = new MemoryManagerSymbols(platform);
			LocalHeap = new LocalHeapSymbols(platform);
			HeapNode = new HeapNodeSymbols(platform);
		}

		public Version Version;
		public Platform Platform;

		public DataSegmentSymbols DataSegment;
		public ObjectManagerSymbols ObjectManager;
		public ActorSymbols Actor;
		public ACDManagerSymbols ACDManager;
		public ACDSymbols ACD;
		public LocalDataSymbols LocalData;
		public FastAttribSymbols FastAttrib;
		public FastAttribGroupSymbols FastAttribGroup;
		public PlayerDataManagerSymbols PlayerDataManager;
		public PlayerDataSymbols PlayerData;
		public SceneSymbols Scene;
		public WorldSymbols World;
		public QuestManagerSymbols QuestManager;
		public QuestSymbols Quest;
		public WaypointManagerSymbols WaypointManager;
		public WaypointSymbols Waypoint;
		public TrickleManagerSymbols TrickleManager;
		public TrickleSymbols Trickle;
		public UIManagerSymbols UIManager;
		public LevelAreaSymbols LevelArea;
		public PlayerSymbols Player;
		public AttributeDescriptorSymbols AttributeDescriptor;
		public FloatingNumberSymbols FloatingNumber;
		public TimedEventSymbols TimedEvent;
		public MemoryManagerSymbols MemoryManager;
		public LocalHeapSymbols LocalHeap;
		public HeapNodeSymbols HeapNode;
	}

	public struct DataSegmentSymbols
	{
		public DataSegmentSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				Address = 0x0199B000;
				VideoPreferences = 0x019CD0A0;
				SoundPreferences = 0x019CD140;
				HotkeyPreferences = 0x019CD190;
				GameplayPreferences = 0x019CD610;
				SocialPreferences = 0x019CD674;
				ChatPreferences = 0x019CD6A4;
				LevelArea = 0x01B9D68C;
				LevelAreaName = 0x01B9D6BC;
				LevelAreaNameLength = 0x80;
				MapActID = 0x01B9DA00;
				ScreenManagerRoot = 0x01B9DC5C;
				TrickleManager = 0x01BEFA08;
				LocalData = 0x01C14148;
				ObjectManager = 0x01C12E98;
				ApplicationLoopCount = 0x01C12F14;
				AttributeDescriptors = 0x01C65660;
				AttributeDescriptorsCount = 1442;
				MemoryManager = 0x01CD2ED0;
			}
			else if (platform == Platform.X64)
			{
				Address = 0x00000001415CD000;
				VideoPreferences = 0x0000000141616DF0;
				SoundPreferences = 0x0000000141616E90;
				HotkeyPreferences = 0x0000000141616EE0;
				GameplayPreferences = 0x0000000141617360;
				SocialPreferences = 0x00000001416173C4;
				ChatPreferences = 0x00000001416173F4;
				LevelArea = 0x00000001417F8698;
				LevelAreaName = 0x00000001417F86A0;
				LevelAreaNameLength = 0x80;
				MapActID = 0x00000001417F8A38;
				ScreenManagerRoot = 0x00000001417F8C98;
				TrickleManager = 0x000000000141850888;
				LocalData = 0x000000014187D758;
				ObjectManager = 0x000000014187D7A0;
				ApplicationLoopCount = 0x000000014187D824;
				AttributeDescriptors = 0x00000001418E9770;
				AttributeDescriptorsCount = 0x000005A2;
				MemoryManager = 0x0000000141981288;
			}
			else throw new PlatformNotSupportedException();
		}

		public ulong Address;
		public ulong VideoPreferences;
		public ulong SoundPreferences;
		public ulong HotkeyPreferences;
		public ulong GameplayPreferences;
		public ulong SocialPreferences;
		public ulong ChatPreferences;
		public ulong LevelArea;
		public ulong LevelAreaName;
		public int LevelAreaNameLength;
		public ulong MapActID;
		public ulong ScreenManagerRoot;
		public ulong TrickleManager;
		public ulong LocalData;
		public ulong ObjectManager;
		public ulong ApplicationLoopCount;
		public ulong AttributeDescriptors;
		public int AttributeDescriptorsCount;
		public ulong MemoryManager;
	}

	public struct ObjectManagerSymbols
	{
		public ObjectManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0xA40;
				RenderTick = 0x038; // TODO
				GameState = -1; // TODO
				GameServerAddress = -1; // TODO
				GameServerAddressLength = 128;
				Storage = 0x7C0;
				GameHandicap = Storage + 0x004; // TODO
				GameStartingAct = Storage + 0x04C; // TODO
				GameBountyBonus = Storage + 0x050; // TODO
				GameTick = Storage + 0x120; // TODO
				PlayerDataManager = Storage + 0x134;
				FastAttrib = Storage + 0x154;
				ACDManager = Storage + 0x160;
				QuestManager = Storage + 0x170;
				WaypointManager = Storage + 0x19C;
				Actors = 0x988;
				Scenes = 0x9C8;
				UIManager = 0x9FC;
				Worlds = 0xA04;
				Player = 0xA0C;
				TimedEvents = 0xA34;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0xB98;
				RenderTick = 0x060;
				GameState = 0x084;
				GameServerAddress = 0x0C0;
				GameServerAddressLength = 128;
				Storage = 0x7C8;
				GameHandicap = Storage + 0x004;
				GameStartingAct = Storage + 0x04C;
				GameBountyBonus = Storage + 0x050;
				GameTick = Storage + 0x120;
				PlayerDataManager = Storage + 0x140;
				FastAttrib = Storage + 0x180;
				ACDManager = Storage + 0x198;
				QuestManager = Storage + 0x1B8;
				WaypointManager = Storage + 0x210;
				Actors = 0xA28;
				Scenes = 0xAA8;
				UIManager = 0xB10;
				Worlds = 0xB20;
				Player = 0xB30;
				TimedEvents = 0xB80;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int RenderTick;
		public int GameState;
		public int GameServerAddress;
		public int GameServerAddressLength;
		public int Storage;
		public int GameHandicap;
		public int GameStartingAct;
		public int GameBountyBonus;
		public int GameTick;
		public int PlayerDataManager;
		public int FastAttrib;
		public int ACDManager;
		public int QuestManager;
		public int WaypointManager;
		public int Actors;
		public int Scenes;
		public int UIManager;
		public int Worlds;
		public int Player;
		public int TimedEvents;
	}

	public struct ActorSymbols
	{
		public ActorSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x454;
				ID = 0x000;
				Name = 0x004;
				NameLength = 0x080;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x4F8;
				ID = 0x000;
				Name = 0x004;
				NameLength = 0x080;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int ID;
		public int Name;
		public int NameLength;
	}

	public struct ACDManagerSymbols
	{
		public ACDManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0xE8;
				ActorCommonData = 0x00;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = -1; // TODO
				ActorCommonData = 0x00;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int ActorCommonData;
	}

	public struct ACDSymbols
	{
		public ACDSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x2F8;
				ID = 0x000;
				Name = 0x004;
				NameLength = 0x080;
				ActorSNO = 0x090;
				MonsterQuality = 0x0B8;
				Position = 0x0D0;
				Radius = 0x0DC;
				WorldSNO = 0x108;
				GizmoType = 0x180;
				ActorType = 0x184;
				Hitpoints = 0x188;
				TeamID = 0x190;
				ObjectFlags = 0x198;
				CollisionFlags = 0x248;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x3A8;
				ID = 0x000;
				Name = 0x004;
				NameLength = 0x080;
				ActorSNO = -1; // TODO
				MonsterQuality = -1; // TODO
				Position = 0x0D8;
				Radius = -1; // TODO
				WorldSNO = 0x118;
				GizmoType = -1; // TODO
				ActorType = -1; // TODO
				Hitpoints = -1; // TODO
				TeamID = -1; // TODO
				ObjectFlags = -1; // TODO
				CollisionFlags = -1; //TODO
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int ID;
		public int Name;
		public int NameLength;
		public int ActorSNO;
		public int MonsterQuality;
		public int Position;
		public int Radius;
		public int WorldSNO;
		public int GizmoType;
		public int ActorType;
		public int Hitpoints;
		public int TeamID;
		public int ObjectFlags;
		public int CollisionFlags;
	}

	public struct LocalDataSymbols
	{
		public LocalDataSymbols(Platform platform)
		{
			if (platform == Platform.X86 ||
				platform == Platform.X64)
			{
				SizeOf = 0x38;
				IsPlayerValid = 0x00;
				IsStartUpGame = 0x04;
				SceneSNO = 0x08;
				WorldSNO = 0x0C;
				ActorSNO = 0x10;
				ActID = 0x14;
				WorldSeed = 0x18;
				QuestSNO = 0x1C;
				QuestStepUID = 0x20;
				WorldPos = 0x24;
				PlayerCount = 0x30;
				LocalPlayerCount = 0x34;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int IsPlayerValid;
		public int IsStartUpGame;
		public int SceneSNO;
		public int WorldSNO;
		public int ActorSNO;
		public int ActID;
		public int WorldSeed;
		public int QuestSNO;
		public int QuestStepUID;
		public int WorldPos;
		public int PlayerCount;
		public int LocalPlayerCount;
	}

	public struct FastAttribSymbols
	{
		public FastAttribSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x5C;
				FastAttribGroups = 0x54;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0xA0;
				FastAttribGroups = 0x90;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int FastAttribGroups;
	}

	public struct FastAttribGroupSymbols
	{
		public FastAttribGroupSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x9C8;
				ID = 0x000;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x12E8;
				ID = 0x0000;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int ID;
	}

	public struct PlayerDataManagerSymbols
	{
		public PlayerDataManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x59BB8;
				Items = 0x00000;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x5AB60;
				Items = 0x00000;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int Items;
	}

	public struct PlayerDataSymbols
	{
		public PlayerDataSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0xB370;
				Index = 0x0000;
				ACDID = 0x0004;
				ActorID = 0x0008;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0xB560;
				Index = 0x0000;
				ACDID = 0x0004;
				ActorID = 0x0008;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int Index;
		public int ACDID;
		public int ActorID;
	}

	public struct SceneSymbols
	{
		public SceneSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x6C8;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x7B8;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
	}

	public struct WorldSymbols
	{
		public WorldSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x68;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x98;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
	}

	public struct QuestManagerSymbols
	{
		public QuestManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x450;
				Quests = 0x01C;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x4A0;
				Quests = 0x030;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int Quests;
	}

	public struct QuestSymbols
	{
		public QuestSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x168;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x168;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
	}

	public struct WaypointManagerSymbols
	{
		public WaypointManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x0C;
				Array = 0x00;
				Count = 0x04;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x18;
				Array = 0x00;
				Count = 0x08;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int Array;
		public int Count;
	}

	public struct WaypointSymbols
	{
		public WaypointSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x2C;
				ActID = 0x00;
				LevelAreaSNO = 0x0C;
				X = 0x24;
				Y = 0x28;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x2C;
				ActID = 0x00;
				LevelAreaSNO = 0x0C;
				X = 0x24;
				Y = 0x28;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int ActID;
		public int LevelAreaSNO;
		public int X;
		public int Y;
	}

	public struct TrickleManagerSymbols
	{
		public TrickleManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x08;
				Allocator = 0x00;
				Items = 0x04;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x10;
				Allocator = 0x00;
				Items = 0x08;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int Allocator;
		public int Items;
	}

	public struct TrickleSymbols
	{
		public TrickleSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x68;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x68;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
	}

	public struct UIManagerSymbols
	{
		public UIManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x2780;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x27B8;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
	}

	public struct LevelAreaSymbols
	{
		public LevelAreaSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x938;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x980;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
	}

	public struct PlayerSymbols
	{
		public PlayerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0xA128;
				LocalPlayerIndex = 0x0000;
				LatencySamples = 0xA0CC;
				FloatingNumbers = -1; // TODO
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0xA3C8;
				LocalPlayerIndex = 0x0000;
				LatencySamples = 0xA348;
				FloatingNumbers = 0xA218;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int LocalPlayerIndex;
		public int LatencySamples;
		public int FloatingNumbers;
	}

	public struct AttributeDescriptorSymbols
	{
		public AttributeDescriptorSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x28;
				ID = 0x00;
				DataType = 0x10;
				Name = 0x1C;
				NameLength = 256;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x40;
				ID = 0x00;
				DataType = 0x10;
				Name = 0x28;
				NameLength = 256;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int ID;
		public int DataType;
		public int Name;
		public int NameLength;
	}

	public struct FloatingNumberSymbols
	{
		public FloatingNumberSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x50;
				WorldPos = 0x04;
				WorldSNO = 0x10;
				Type = 0x48;
				Value = 0x4C;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x64;
				WorldPos = 0x04;
				WorldSNO = 0x10;
				Type = 0x5C;
				Value = 0x60;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int WorldPos;
		public int WorldSNO;
		public int Type;
		public int Value;
	}

	public struct TimedEventSymbols
	{
		public TimedEventSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x0C;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x0C;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
	}

	public struct MemoryManagerSymbols
	{
		public MemoryManagerSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				SizeOf = 0x38;
				LocalHeap = 0x30;
			}
			else if (platform == Platform.X64)
			{
				SizeOf = 0x68;
				LocalHeap = 0x58;
			}
			else throw new PlatformNotSupportedException();
		}

		public int SizeOf;
		public int LocalHeap;
	}

	public struct LocalHeapSymbols
	{
		public LocalHeapSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				FirstNode = 0x04;
				TotalSize = 0x08;
				NodeCount = 0x10;
				LastNode = 0x38;
			}
			else if (platform == Platform.X64)
			{
				FirstNode = 0x08;
				TotalSize = 0x10;
				NodeCount = 0x20;
				LastNode = 0x68;
			}
			else throw new PlatformNotSupportedException();
		}

		public int FirstNode;
		public int TotalSize;
		public int NodeCount;
		public int LastNode;
	}

	public struct HeapNodeSymbols
	{
		public HeapNodeSymbols(Platform platform)
		{
			if (platform == Platform.X86)
			{
				HeaderSize = 0x10;
				SizeAndFlag = 0x0C;
			}
			else if (platform == Platform.X64)
			{
				HeaderSize = 0x20;
				SizeAndFlag = 0x18;
			}
			else throw new PlatformNotSupportedException();
		}

		public int HeaderSize;
		public int SizeAndFlag;
	}
}
