using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.Application.Cart.Commands
{
    public class AddProductCommand : IRequest<Domain.Entity.Cart>
    {
        
    }

    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Domain.Entity.Cart>
    {
        public Task<Domain.Entity.Cart> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
