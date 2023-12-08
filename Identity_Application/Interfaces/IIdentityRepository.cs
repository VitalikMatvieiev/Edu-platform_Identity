﻿using Identity_Domain.Entities.Base;

namespace Identity_Application.Interfaces;

public interface IIdentityRepository
{
    Task<ICollection<Identity>> GetAll();

    Task<Identity> GetIdentityById(int identityId);

    Task<Identity> AddIdentity(Identity toCreate);

    Task<Identity> UpdateIdentity(int identityId, string name, string email);

    Task DeleteIdentity(int identityId);
}