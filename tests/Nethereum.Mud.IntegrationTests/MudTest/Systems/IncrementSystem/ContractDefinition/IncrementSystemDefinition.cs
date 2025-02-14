using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Nethereum.Mud.IntegrationTests.MudTest.Systems.IncrementSystem.ContractDefinition
{


    public partial class IncrementSystemDeployment : IncrementSystemDeploymentBase
    {
        public IncrementSystemDeployment() : base(BYTECODE) { }
        public IncrementSystemDeployment(string byteCode) : base(byteCode) { }
    }

    public class IncrementSystemDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "608060405234801561000f575f80fd5b50610e1f8061001d5f395ff3fe608060405234801561000f575f80fd5b5060043610610055575f3560e01c806301ffc9a714610059578063119df25f1461008157806345ec9354146100a1578063d09de08a146100b4578063e1af802c146100d1575b5f80fd5b61006c610067366004610b57565b6100d9565b60405190151581526020015b60405180910390f35b61008961010f565b6040516001600160a01b039091168152602001610078565b604051601f193601358152602001610078565b6100bc61011d565b60405163ffffffff9091168152602001610078565b610089610140565b5f6001600160e01b0319821663b5dee12760e01b148061010957506001600160e01b031982166301ffc9a760e01b145b92915050565b5f610118610149565b905090565b5f8061012761015d565b90505f610135826001610b92565b90506101098161019b565b5f6101186101fa565b60331936013560601c8061015a5750335b90565b604080515f808252602082019092525f6101916621b7bab73a32b960491b613a3160f11b018383630100400160da1b610203565b60e01c9392505050565b604080515f80825260208201835260e084901b6001600160e01b03191682840152825180830360240181526044830190935290916101f6916621b7bab73a32b960491b613a3160f11b0191849190630100400160da1b6102ac565b5050565b5f610118610343565b5f8061020d610343565b9050306001600160a01b038216036102335761022b86868686610381565b9150506102a4565b604051638c364d5960e01b81526001600160a01b03821690638c364d5990610265908990899089908990600401610bf0565b602060405180830381865afa158015610280573d5f803e3d5ffd5b505050506040513d601f19601f8201168201806040525081019061022b9190610c1e565b949350505050565b5f6102b5610343565b9050306001600160a01b038216036102d9576102d486868686866103b6565b61033b565b6040516301c85d5760e51b81526001600160a01b0382169063390baae09061030d9089908990899089908990600401610c78565b5f604051808303815f87803b158015610324575f80fd5b505af1158015610336573d5f803e3d5ffd5b505050505b505050505050565b7f629a4c26e296b22a8e0856e9f6ecb2d1008d7e00081111962cd175fa7488e175545f906001600160a01b03168061037c573391505090565b919050565b5f6103ad61038f86866103d2565b60ff858116601b0360080285901c166103a88587610427565b61045f565b95945050505050565b6103cb85856103c58487610427565b856104af565b5050505050565b5f82826040516020016103e6929190610cbe565b60408051601f1981840301815291905280516020909101207f86425bff6b57326c7859e89024fe4f238ca327a1ae4a230180dd2f0e88aaa7d9189392505050565b5f80805b8360ff168110156104575761044d60ff601b83900360080287901c1683610cf8565b915060010161042b565b509392505050565b5f602082106104845760208204840193506020828161048057610480610d0b565b0691505b508254600882021b602082900380841115610457576001850154600882021c82179150509392505050565b611bdd60f21b846001600160f01b0319160361050657837f8c0b5119d4cec7b284c6b1b39252a03d1e2f2d7451a5895562524c113bb952be8484846040516104f993929190610d1f565b60405180910390a26106d9565b5f61051185856103d2565b90505f61051d866106df565b90505f5b81518110156105d2575f82828151811061053d5761053d610d5b565b602002602001015190506105696004826affffffffffffffffffffff191661076490919063ffffffff16565b156105c95760405163964f667d60e01b8152606082901c9063964f667d9061059b908b908b908b908b90600401610d6f565b5f604051808303815f87803b1580156105b2575f80fd5b505af11580156105c4573d5f803e3d5ffd5b505050505b50600101610521565b50857f8c0b5119d4cec7b284c6b1b39252a03d1e2f2d7451a5895562524c113bb952be86868660405161060793929190610d1f565b60405180910390a2610622828565ffffffffffff1685610781565b5f5b81518110156106d5575f82828151811061064057610640610d5b565b6020026020010151905061066c6008826affffffffffffffffffffff191661076490919063ffffffff16565b156106cc5760405163a8ba872160e01b8152606082901c9063a8ba87219061069e908b908b908b908b90600401610d6f565b5f604051808303815f87803b1580156106b5575f80fd5b505af11580156106c7573d5f803e3d5ffd5b505050505b50600101610624565b5050505b50505050565b6040805160018082528183019092526060915f91906020808301908036833701905050905082815f8151811061071757610717610d5b565b60209081029190910101525f61074e7f746273746f726500000000000000000053746f7265486f6f6b73000000000000838361079c565b90506102a461075f825f84516107d5565b610848565b5f8160ff16826107748560581c90565b1660ff1614905092915050565b610797838383516107928560200190565b61085e565b505050565b60606102a46107ac85858561091d565b5f6107d0856107bb8989610983565b9060ff166028026038011c64ffffffffff1690565b610995565b5f818311806107e45750835182115b15610811578383836040516323230fa360e01b815260040161080893929190610db2565b60405180910390fd5b6020840161081f8482610cf8565b90505f61082c8585610dd6565b6001600160801b031660809290921b9190911795945050505050565b60605f6108578360155f6109b8565b9392505050565b82156108d857602083106108885760208304840193506020838161088457610884610d0b565b0692505b82156108d85760208390035f61089d84610a27565b1990506008850281811c91508351811c90508119875416828216178755508184116108c95750506106d9565b50600194909401939182900391015b5b602082106108fa5780518455600190930192601f19909101906020016108d9565b81156106d9575f61090a83610a27565b8554835182191691161785555050505050565b5f8383604051602001610931929190610cbe565b604051602081830303815290604052805190602001208260f81b6001600160f81b0319167f3b4102da22e32d82fc925482184f16c09fd4281692720b87d124aef6da48a0f118185f1c90509392505050565b5f6108576109918484610a33565b5490565b60405160208101601f19603f848401011660405282825261045785858584610a88565b60605f6109c58560801c90565b90506001600160801b0385165f8582816109e1576109e1610d0b565b0490506040519350602084016020820281016040528185525f5b82811015610a1b578451871c8252938701936020909101906001016109fb565b50505050509392505050565b5f196008919091021c90565b5f8282604051602001610a47929190610cbe565b60408051601f1981840301815291905280516020909101207f14e2fcc58e58e68ec7edc30c8d50dccc3ce2714a623ec81f46b6a63922d76569189392505050565b8215610b125760208310610ab257602083048401935060208381610aae57610aae610d0b565b0692505b8215610b125760208390035f81841015610ad657610acf84610a27565b9050610ae2565b610adf82610a27565b90505b8554600886021b818451168219821617845250818411610b035750506106d9565b50600194909401939182900391015b5b60208210610b345783548152600190930192601f1990910190602001610b13565b81156106d9575f610b4483610a27565b8251865482191691161782525050505050565b5f60208284031215610b67575f80fd5b81356001600160e01b031981168114610857575f80fd5b634e487b7160e01b5f52601160045260245ffd5b63ffffffff818116838216019080821115610baf57610baf610b7e565b5092915050565b5f815180845260208085019450602084015f5b83811015610be557815187529582019590820190600101610bc9565b509495945050505050565b848152608060208201525f610c086080830186610bb6565b60ff949094166040830152506060015292915050565b5f60208284031215610c2e575f80fd5b5051919050565b5f81518084525f5b81811015610c5957602081850181015186830182015201610c3d565b505f602082860101526020601f19601f83011685010191505092915050565b85815260a060208201525f610c9060a0830187610bb6565b60ff861660408401528281036060840152610cab8186610c35565b9150508260808301529695505050505050565b8281525f60208083018451602086015f5b82811015610ceb57815184529284019290840190600101610ccf565b5091979650505050505050565b8082018082111561010957610109610b7e565b634e487b7160e01b5f52601260045260245ffd5b606081525f610d316060830186610bb6565b65ffffffffffff851660208401528281036040840152610d518185610c35565b9695505050505050565b634e487b7160e01b5f52603260045260245ffd5b848152608060208201525f610d876080830186610bb6565b65ffffffffffff851660408401528281036060840152610da78185610c35565b979650505050505050565b606081525f610dc46060830186610c35565b60208301949094525060400152919050565b8181038181111561010957610109610b7e56fea2646970667358221220dde13fbce70cd2805038ea856f8bf86f04fc4610ee4f2546fb3a61c13d933adb64736f6c63430008180033";
        public IncrementSystemDeploymentBase() : base(BYTECODE) { }
        public IncrementSystemDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class MsgSenderFunction : MsgSenderFunctionBase { }

    [Function("_msgSender", "address")]
    public class MsgSenderFunctionBase : FunctionMessage
    {

    }

    public partial class MsgValueFunction : MsgValueFunctionBase { }

    [Function("_msgValue", "uint256")]
    public class MsgValueFunctionBase : FunctionMessage
    {

    }

    public partial class WorldFunction : WorldFunctionBase { }

    [Function("_world", "address")]
    public class WorldFunctionBase : FunctionMessage
    {

    }

    public partial class IncrementFunction : IncrementFunctionBase { }

    [Function("increment", "uint32")]
    public class IncrementFunctionBase : FunctionMessage
    {

    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class StoreSplicestaticdataEventDTO : StoreSplicestaticdataEventDTOBase { }

    [Event("Store_SpliceStaticData")]
    public class StoreSplicestaticdataEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "tableId", 1, true)]
        public virtual byte[] TableId { get; set; }
        [Parameter("bytes32[]", "keyTuple", 2, false)]
        public virtual List<byte[]> KeyTuple { get; set; }
        [Parameter("uint48", "start", 3, false)]
        public virtual ulong Start { get; set; }
        [Parameter("bytes", "data", 4, false)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SliceOutofboundsError : SliceOutofboundsErrorBase { }

    [Error("Slice_OutOfBounds")]
    public class SliceOutofboundsErrorBase : IErrorDTO
    {
        [Parameter("bytes", "data", 1)]
        public virtual byte[] Data { get; set; }
        [Parameter("uint256", "start", 2)]
        public virtual BigInteger Start { get; set; }
        [Parameter("uint256", "end", 3)]
        public virtual BigInteger End { get; set; }
    }

    public partial class MsgSenderOutputDTO : MsgSenderOutputDTOBase { }

    [FunctionOutput]
    public class MsgSenderOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "sender", 1)]
        public virtual string Sender { get; set; }
    }

    public partial class MsgValueOutputDTO : MsgValueOutputDTOBase { }

    [FunctionOutput]
    public class MsgValueOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("uint256", "value", 1)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class WorldOutputDTO : WorldOutputDTOBase { }

    [FunctionOutput]
    public class WorldOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }
}
