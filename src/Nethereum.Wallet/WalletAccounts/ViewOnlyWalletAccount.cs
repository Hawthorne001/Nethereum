﻿using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Nethereum.RPC.Accounts;
using Nethereum.Accounts.ViewOnly;

namespace Nethereum.Wallet.WalletAccounts;

public class ViewOnlyWalletAccount : WalletAccountBase
{
    public static readonly string TypeName = "viewonly";
    public override string Type => TypeName;

    public override object Settings => null;

    public ViewOnlyWalletAccount(string address, string label) : base(address, label) { }

    public override Task<IAccount> GetAccountAsync()
    {
        return Task.FromResult<IAccount>(new ViewOnlyAccount(this.Address));
    }

    public override JsonObject ToJson() => new()
    {
        ["type"] = Type,
        ["address"] = Address,
        ["label"] = Label,
        ["selected"] = IsSelected,
    };

    public static ViewOnlyWalletAccount FromJson(JsonElement json)
    {
        var address = json.GetProperty("address").GetString()!;
        var label = json.GetProperty("label").GetString()!;
        return new ViewOnlyWalletAccount(address, label);
    }
}


//public class GnosisSafeWalletAccount : WalletAccountBase
//{
//    public override string Type => "gnosis_safe";
//    private readonly IAccount _ownerAccount;

//    public override object Settings => new { SafeAddress = Address };

//    public GnosisSafeWalletAccount(string safeAddress, string label, IAccount ownerAccount)
//        : base(safeAddress, label)
//    {
//        _ownerAccount = ownerAccount;
//    }

//    public override Task<IAccount> GetAccountAsync() => Task.FromResult(_ownerAccount);

//    public override async Task<IWeb3> CreateWeb3Async(IClient client)
//    {
//        var web3 = new Nethereum.Web3.Web3(_ownerAccount, client);
//        web3.Eth.Safe

//        return web3;
//    }

//    public override JsonObject ToJson() => new()
//    {
//        ["type"] = Type,
//        ["address"] = Address,
//        ["label"] = Label
//    };
//}

